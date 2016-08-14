﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Drawing;
using Common.Lib;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Threading;

namespace Service
{
    public class TelaPixel
    {
        #region Singleton
        private static TelaPixel objTelaPixel;

        public static TelaPixel obterInstancia()
        {
            if (TelaPixel.objTelaPixel == null)
            {
                TelaPixel.objTelaPixel = new TelaPixel();
            }
            return TelaPixel.objTelaPixel;
        }
        #endregion

        public VFBitmapLocker objVFBitmapLocker;

        public string obterPixel(Model.Tela objModelTela)
        {
            Color objColor = this.objVFBitmapLocker.getPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            return Common.ColorHelper.HexConverter(objColor);
        }

        public string obterPixel(int eixoHorizontal, int eixoVertical)
        {
            Color objColor = this.objVFBitmapLocker.getPixel(eixoHorizontal, eixoVertical);
            return Common.ColorHelper.HexConverter(objColor);
        }

        // Percentual: Entre 0 e 1
        public string obterPixelClaro(Model.Tela objModelTela, float percentual)
        {
            Color objColor = this.objVFBitmapLocker.getPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            objColor = ControlPaint.Light(objColor, percentual);
            return Common.ColorHelper.HexConverter(objColor);
        }

        // Percentual: Entre 0 e 1
        public string obterPixelEscuro(Model.Tela objModelTela, float percentual)
        {
            Color objColor = this.objVFBitmapLocker.getPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            objColor = ControlPaint.Dark(objColor, percentual);

            return Common.ColorHelper.HexConverter(objColor);
        }

        public Color mudarClaridadeCor(Color objColor, float fatorCorrecao)
        {
            float red = (float)objColor.R;
            float green = (float)objColor.G;
            float blue = (float)objColor.B;

            if (fatorCorrecao < 0)
            {
                // escuro
                fatorCorrecao = 1 + fatorCorrecao;
                red *= fatorCorrecao;
                green *= fatorCorrecao;
                blue *= fatorCorrecao;
            }
            else
            {
                //claro
                red = (255 - red) * fatorCorrecao + red;
                green = (255 - green) * fatorCorrecao + green;
                blue = (255 - blue) * fatorCorrecao + blue;
            }

            return Color.FromArgb(objColor.A, (int)red, (int)green, (int)blue);
        }

        public bool compararClaridadeCores(Color objCorCorreta, Color objCorComparacao)
        {
            float brightnessCorreta = objCorCorreta.GetBrightness();
            float brightnessComparacao = objCorComparacao.GetBrightness();
            if (brightnessCorreta != brightnessComparacao)
            {
                if (brightnessCorreta > brightnessComparacao)
                {
                    //0.17f
                    for (float fatorCorrecao = 0.01f; fatorCorrecao <= 1f; fatorCorrecao += 0.01f)
                    {
                        brightnessComparacao = TelaPixel.obterInstancia().mudarClaridadeCor(objCorComparacao, fatorCorrecao).GetBrightness();
                        if (brightnessCorreta == brightnessComparacao)
                        {
                            //TelaPixel.obterInstancia().luminosidade = fatorCorrecao;
                            return true;
                        }
                    }
                }
                else
                {
                    for (float fatorCorrecao = -0.01f; fatorCorrecao >= -1f; fatorCorrecao -= 0.01f)
                    {
                        brightnessComparacao = TelaPixel.obterInstancia().mudarClaridadeCor(objCorComparacao, fatorCorrecao).GetBrightness();
                        if (brightnessCorreta == brightnessComparacao)
                        {
                            //TelaPixel.obterInstancia().luminosidade = fatorCorrecao;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // seria isPixelVariavel + compararHSL
        public bool isPixelVariavel(Model.Tela objModelTela, string pixelComparacao)
        {
            Color objColorAtual = this.objVFBitmapLocker.getPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            Color objCorCorreta = System.Drawing.ColorTranslator.FromHtml(pixelComparacao);
            byte variacaoPixel = 22;
            if (
                (objCorCorreta.R + variacaoPixel >= objColorAtual.R && objCorCorreta.R - variacaoPixel <= objColorAtual.R)
                && (objCorCorreta.G + variacaoPixel >= objColorAtual.G && objCorCorreta.G - variacaoPixel <= objColorAtual.G)
                && (objCorCorreta.B + variacaoPixel >= objColorAtual.B && objCorCorreta.B - variacaoPixel <= objColorAtual.B)
                )
            {
                return true;
            }
            return false;
        }

        public bool compararHSL(Model.Tela objModelTela, string pixelComparacao)
        {
            Color objCorAtual = this.objVFBitmapLocker.getPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            Color objCorCorreta = System.Drawing.ColorTranslator.FromHtml(pixelComparacao);

            HSLColor objCorAtualHSL = HSLColor.FromRGB(objCorAtual);
            HSLColor objCorCorretaHSL = HSLColor.FromRGB(objCorCorreta);
            
            float variacaoSaturacao = 0.09f;
            float variacaoLuminosidade = 0.09f;
            if (
                   (objCorAtualHSL.Luminosity + variacaoLuminosidade >= objCorCorretaHSL.Luminosity && objCorAtualHSL.Luminosity - variacaoLuminosidade <= objCorCorretaHSL.Luminosity)
                && (objCorAtualHSL.Saturation + variacaoSaturacao >= objCorCorretaHSL.Saturation && objCorAtualHSL.Saturation - variacaoSaturacao <= objCorCorretaHSL.Saturation)
                ) {
                return true;
            }
            return false;
        }
        
        public bool isPixelEncontrado(int eixoHorizontal, int eixoVertical, string pixelComparacao)
        {
            if ( eixoHorizontal > 0 && eixoVertical > 0 ) {
                if (this.obterPixel(eixoHorizontal, eixoVertical) == pixelComparacao) return true;
                //if (this.isPixelVariavel(objModelTela, pixelComparacao)) return true;
                //if (this.compararHSL(objModelTela, pixelComparacao)) return true;
            }
            return false;
            
        }

        /// <summary>
        /// Método responsável por procurar padrões de pixels e executar ações.
        /// </summary>
        /// <typeparam name="TRetornoBusca">Parâmetro do Tipo Anônimo utilizado como tipo de retorno no método delegável "objMetodoBusca".</typeparam>
        /// <typeparam name="TParametroAcaoResultado">Parâmetro do Tipo Anônimo utilizado na assinatura do método delegável "objMetodoAcao".</typeparam>
        /// <param name="objMetodoBusca">Função por delegação, que recebe um método delegável(delegate), com o primeiro parâmetro do tipo ModelTela e retorna um boolean como resultado.</param>
        /// <param name="objMetodoAcao">Função por delegação, que recebe um método delegável(delegate), com o primeiro parâmetro um Tipo Anônimo e retorna um boolean como resultado.</param>
        /// <returns></returns>
        public TParametroAcaoResultado procurarPadroesPixels<TRetornoBusca, TParametroAcaoResultado>(
            Func<Model.Tela, TRetornoBusca> objMetodoBusca, 
            Func<Model.Tela, TRetornoBusca, TParametroAcaoResultado, TParametroAcaoResultado> objMetodoAcao
            )
        {
            TParametroAcaoResultado objTTipoAcaoBusca = default(TParametroAcaoResultado);
            try
            {
                Model.Tela objModelTela = new Model.Tela();
                String horarioAtual = System.DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
                Bitmap objBitmap = TelaCaptura.obterInstancia().obterImagemTelaComo8bitesPorPixel();

                /*using (Graphics objGraphicsScreenshot = Graphics.FromImage(objBitmap)) 
                { 
                    // Tira uma printScreen do canto superior esquerdo até o canto inferior direito.
                    objGraphicsScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                                Screen.PrimaryScreen.Bounds.Y,
                                                0,
                                                0,
                                                Screen.PrimaryScreen.Bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                }*/


                using (this.objVFBitmapLocker = new Common.Lib.VFBitmapLocker(objBitmap))
                { 
                    TRetornoBusca objRetornoBusca = default(TRetornoBusca);
                    for (int totalPixels = 0; totalPixels < this.objVFBitmapLocker.height * this.objVFBitmapLocker.width; totalPixels++)
                    {
                        objModelTela.eixoHorizontal = totalPixels % this.objVFBitmapLocker.width;
                        objModelTela.eixoVertical = totalPixels / this.objVFBitmapLocker.width;
                        
                        objRetornoBusca = objMetodoBusca(objModelTela);
                        if (objRetornoBusca != null)
                        {
                            objTTipoAcaoBusca = objMetodoAcao(objModelTela, objRetornoBusca, objTTipoAcaoBusca);
                        }
                    }
                MessageBox.Show("Iniciado em: " + horarioAtual + "\n Concluído em: " + System.DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));

                }

            }
            catch (Exception objException)
            {
                throw new Exception(objException.ToString());
            }
            return objTTipoAcaoBusca;
        }
        
        public Model.Tela procurarImagemPorTemplate(string caminhoTemplateRecurso)
        {
            Service.TelaCaptura objServiceTelaCaptura = Service.TelaCaptura.obterInstancia();
            Bitmap objBitmapTemplate = new Bitmap(caminhoTemplateRecurso);

            if(objServiceTelaCaptura.isUtilizarMascaraLuminosidade)
            {
                objServiceTelaCaptura.valorTransparencia = objServiceTelaCaptura.obterValorTransparenciaPorHorario();
                objBitmapTemplate = objServiceTelaCaptura.aplicarMascaraNegraImagem(objBitmapTemplate, objServiceTelaCaptura.valorTransparencia);
            }

            objBitmapTemplate = objServiceTelaCaptura.converterImagemPara8bitesPorPixel(objBitmapTemplate);

            Image<Emgu.CV.Structure.Gray, byte> objImagemTelaAtual = new Image<Emgu.CV.Structure.Gray, byte>(TelaCaptura.obterInstancia().obterImagemTelaComo8bitesPorPixel()); // Image B
            Image<Emgu.CV.Structure.Gray, byte> objImagemTemplate = new Image<Emgu.CV.Structure.Gray, byte>(objBitmapTemplate); // Image A

            Model.Tela objModelTela = new Model.Tela();
            using (Image<Emgu.CV.Structure.Gray, float> result = objImagemTelaAtual.MatchTemplate(objImagemTemplate, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCORR_NORMED))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                
                if (maxValues[0] > 0.5d)
                {
                    objModelTela.eixoHorizontal = maxLocations[0].X;
                    objModelTela.eixoVertical = maxLocations[0].Y;
                }
            }
            
            objImagemTelaAtual.Dispose();
            objBitmapTemplate.Dispose();

            return objModelTela;
        }

        public bool procurarImagemPorTemplateComAcao(string caminhoTemplateRecurso, Func<Model.Tela, bool> objMetodoAcao)
        {
            Model.Tela objModelTela = this.procurarImagemPorTemplate(caminhoTemplateRecurso);
            if (objModelTela.eixoHorizontal > 0 && objModelTela.eixoVertical > 0) return objMetodoAcao(objModelTela);
            return false;
        }

        public Model.Tela buscarImagemPorTemplate(string caminhoTemplateRecurso)
        {
            return buscarImagemPorTemplate(caminhoTemplateRecurso, TelaCaptura.EnumRegiaoTela.TELA_CHEIA);
        }


        public Model.Tela buscarImagemPorTemplate(string caminhoTemplateRecurso, TelaCaptura.EnumRegiaoTela objRegiaoTela)
        {
            Service.TelaCaptura objServiceTelaCaptura = Service.TelaCaptura.obterInstancia();
            Bitmap objBitmapTemplate = new Bitmap(caminhoTemplateRecurso);

            if (objServiceTelaCaptura.isUtilizarMascaraLuminosidade)
            {
                objBitmapTemplate = objServiceTelaCaptura.aplicarMascaraNegraImagem(objBitmapTemplate);
            }

            objBitmapTemplate = objServiceTelaCaptura.converterImagemPara8bitesPorPixel(objBitmapTemplate);

            Image<Emgu.CV.Structure.Gray, byte> objImagemTelaAtual = new Image<Emgu.CV.Structure.Gray, byte>(TelaCaptura.obterInstancia().obterImagemTelaComo8bitesPorPixel(objRegiaoTela)); // Image B
            Image<Emgu.CV.Structure.Gray, byte> objImagemTemplate = new Image<Emgu.CV.Structure.Gray, byte>(objBitmapTemplate); // Image A

            objImagemTelaAtual = objImagemTelaAtual.ThresholdBinary(new Gray(135), new Gray(255));
            objImagemTelaAtual._Not();
            //objImagemTelaAtual.Erode(1);
            //objImagemTemplate = objImagemTemplate.ThresholdBinary(new Gray(115), new Gray(255));
            objImagemTemplate = objImagemTemplate.ThresholdBinary(new Gray(145), new Gray(255));
            objImagemTemplate._Not();

            Model.Tela objModelTela = new Model.Tela();

            using (Image<Emgu.CV.Structure.Gray, float> result = objImagemTelaAtual.MatchTemplate(objImagemTemplate, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                if (maxValues[0] > 0.4d)
                { 
                    objModelTela.eixoHorizontal = maxLocations[0].X + (objBitmapTemplate.Width / 2);
                    objModelTela.eixoVertical = maxLocations[0].Y + (objBitmapTemplate.Height / 2);
                    /*
                     * @todo remover esse trecho comentado. Foi apenas um teste.
                    Win32.posicionarMouse(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
                    Win32.clicarBotaoEsquerdo(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
                    Thread.Sleep(2000);
                    */
                }
            }

            /*using (Image<Emgu.CV.Structure.Gray, float> result = objImagemTelaAtual.MatchTemplate(objImagemTemplate, Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED))
            {
                float[,,] matches = result.Data;
                for (int y = 0; y < matches.GetLength(0); y++)
                {
                    for (int x = 0; x < matches.GetLength(1); x++)
                    {
                        double matchScore = matches[y, x, 0];

                        if (matchScore > 0.6d)
                        {
                            Model.Tela objModelTela = new Model.Tela();

                            objModelTela.eixoHorizontal = x + (objBitmapTemplate.Width / 2);
                            objModelTela.eixoVertical = y + (objBitmapTemplate.Height / 2);
                            objListaModelTela.Add(objModelTela);
                        }
                    }
                }
            }*/

            objImagemTelaAtual.ToBitmap().Save("C:\\Users\\Public\\teste1.bmp");
            objImagemTemplate.ToBitmap().Save("C:\\Users\\Public\\teste2_depois.bmp");
            objImagemTelaAtual.Dispose();
            objBitmapTemplate.Dispose();

            return objModelTela;
        }

    }
}