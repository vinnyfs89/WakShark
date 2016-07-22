﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Drawing;
using Service.Lib;

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
        
        public string obterPixel(Model.Tela objModelTela)
        {
            Color objColor = TelaCaptura.obterInstancia().objLockedBitmap.GetPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            return Service.Common.Color.HexConverter(objColor);
        }

        // Percentual: Entre 0 e 1
        public string obterPixelClaro(Model.Tela objModelTela, float percentual)
        {
            Color objColor = TelaCaptura.obterInstancia().objLockedBitmap.GetPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            objColor = ControlPaint.Light(objColor, percentual);
            return Service.Common.Color.HexConverter(objColor);
        }

        // Percentual: Entre 0 e 1
        public string obterPixelEscuro(Model.Tela objModelTela, float percentual)
        {
            Color objColor = TelaCaptura.obterInstancia().objLockedBitmap.GetPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            objColor = ControlPaint.Dark(objColor, percentual);

            return Service.Common.Color.HexConverter(objColor);
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
            Color objColorAtual = TelaCaptura.obterInstancia().objLockedBitmap.GetPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
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
            Color objCorAtual = TelaCaptura.obterInstancia().objLockedBitmap.GetPixel(objModelTela.eixoHorizontal, objModelTela.eixoVertical);
            Color objCorCorreta = System.Drawing.ColorTranslator.FromHtml(pixelComparacao);

            HSLColor objCorAtualHSL = Service.Lib.HSLColor.FromRGB(objCorAtual);
            HSLColor objCorCorretaHSL = Service.Lib.HSLColor.FromRGB(objCorCorreta);
            
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
                Model.Tela objModelTela = new Model.Tela();
                objModelTela.eixoHorizontal = eixoHorizontal;
                objModelTela.eixoVertical = eixoVertical;
            
                if (this.obterPixel(objModelTela) == pixelComparacao) return true;
                if (this.isPixelVariavel(objModelTela, pixelComparacao)) return true;
                if (this.compararHSL(objModelTela, pixelComparacao)) return true;
            }
            return false;
            
        }


        // objFuncaoValidacao > Função por delegação, que recebe um método delegável(delegate), com 1 parâmetro do tipo ModelTela e retorna um boolean, como resultado;
        public bool procurarPixel(Func<Model.Tela, bool> objMetodoBusca, Func<Model.Tela, bool> objMetodoAcao)
        {
            bool isPararProcura = false;
            try
            {

                Model.Tela objModelTela = new Model.Tela();
                String horarioAtual = System.DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
                using (Bitmap objBitmap = TelaCaptura.obterInstancia().obterImagemTelaComo8bitesPorPixel())
                {
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


                    using (TelaCaptura.obterInstancia().objLockedBitmap = new Service.Lib.LockBitmap(objBitmap))
                    {
                        TelaCaptura.obterInstancia().objLockedBitmap.LockBits();

                        for (int totalPixels = 0; totalPixels < TelaCaptura.obterInstancia().objLockedBitmap.Height * TelaCaptura.obterInstancia().objLockedBitmap.Width; totalPixels++)
                        {
                            objModelTela.eixoHorizontal = totalPixels % TelaCaptura.obterInstancia().objLockedBitmap.Width;
                            objModelTela.eixoVertical = totalPixels / TelaCaptura.obterInstancia().objLockedBitmap.Width;

                            isPararProcura = objMetodoBusca(objModelTela);
                            if (isPararProcura) break;
                        }
                        //MessageBox.Show("Iniciado em: " + horarioAtual + "\n Concluído em: " + System.DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));
                        if (isPararProcura) objMetodoAcao(objModelTela);

                        TelaCaptura.obterInstancia().objLockedBitmap.UnlockBits();
                    }
                }

            }
            catch (Exception objException)
            {
                throw new Exception(objException.ToString());
            }
            return isPararProcura;
        }

    }
}