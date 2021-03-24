using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Supletorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double PrimerNumero;

        public double SegundoNumero;

        private operaciones operacion;

        public enum operaciones
        {
            suma,
            resta,
            multiplicacion,
            division
        }



        public MainWindow()
        {
            InitializeComponent();
        }
        private string Resultado(Double PrimerNumero, Double SegundoNumero, operaciones operacion)
        {
            if(operacion == operaciones.suma)
            {
                return (PrimerNumero + SegundoNumero).ToString();
            } else if(operacion == operaciones.resta)
            {
                return (PrimerNumero - SegundoNumero).ToString();
            }
            else if (operacion == operaciones.multiplicacion)
            {
                return (PrimerNumero * SegundoNumero).ToString();
            } else if (operacion == operaciones.division)
            {
                return (PrimerNumero / SegundoNumero).ToString();
            }else
            {
                return "0";
            }

        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btnpunto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResultado.Text != "0")
            {
                txtResultado.Text = $"{txtResultado.Text}{btn.Content}";
            }
            else
            {
                txtResultado.Text = btn.Content.ToString();
            }
        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            //resultado
            SegundoNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = Resultado(PrimerNumero, SegundoNumero, operacion);

        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            operacion = operaciones.division;
            PrimerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void btnPor_Click(object sender, RoutedEventArgs e)
        {
            operacion = operaciones.multiplicacion;
            PrimerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            operacion = operaciones.resta;
            PrimerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            operacion = operaciones.suma;
            PrimerNumero = double.Parse(txtResultado.Text);
            txtResultado.Text = "0";
        }
    }
}
