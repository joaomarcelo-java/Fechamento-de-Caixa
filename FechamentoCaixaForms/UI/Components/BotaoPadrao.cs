using System.Drawing;
using System.Windows.Forms;

namespace FechamentoCaixa.UI.Components
{
    public class BotaoPadrao : Button
    {
        private TipoBotao tipo = TipoBotao.Azul;

        public TipoBotao Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                AplicarEstilo();
            }
        }

        public BotaoPadrao()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 9F);
            Height = 25;
            Width = 90;

            AplicarEstilo();
        }

        private void AplicarEstilo()
        {
            switch (Tipo)
            {
                case TipoBotao.Lista:
                    BackColor = Color.FromArgb(176, 190, 197); // Cinza pastel
                    break;

                case TipoBotao.Verde:
                    BackColor = Color.FromArgb(102, 187, 106); // Verde pastel
                    break;

                case TipoBotao.Azul:
                    BackColor = Color.FromArgb(100, 149, 237); // Azul pastel
                    break;
            }
        }
    }
}