
using Ejercicio1.Models;
using System.Collections;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    ArrayList figuras = new ArrayList();
    //List<Figura> figuras = new List<Figura>();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnCrearFigura_Click(object sender, EventArgs e)
    {

        //Un ortoedro es Una Figura
        //Pero una Figura no necesariamente es un Ortoedro

        Figura nueva = null;

        if (rbEsTipoCuadrado.Checked == true)
        {
            double ancho = Convert.ToDouble(tbAncho.Text);
            double alto = Convert.ToDouble(tbAlto.Text);
            double largo = Convert.ToDouble(tbLargo.Text);
            nueva = new Ortoedro(ancho, alto, largo );
        }
        else if (rbEsTipoCilindro.Checked == true)
        {
            double radio = Convert.ToDouble(tbRadio.Text);
            double alto = Convert.ToDouble(tbAltoCilindro.Text);
            nueva = new Cilindro( radio, alto);
        }

        if (nueva != null)//verifico si selecciono un tipo de figura 
        {
            figuras.Add(nueva);
        }
        else
        {
            MessageBox.Show("debe seleccionar un tipo de figura.");
        }

        //adicional limpio controles
        rbEsTipoCuadrado.Checked = false;
        rbEsTipoCilindro.Checked = false;
        tbAncho.Clear();
        tbAlto.Clear();
        tbLargo.Clear();
        tbRadio.Clear();
        tbAltoCilindro.Clear();
    }

    private void btnMostrarFiguras_Click(object sender, EventArgs e)
    {
        lbxListaFiguras.Items.Clear();
        foreach (Figura f in figuras)
        {
            lbxListaFiguras.Items.Add(f); //estoy agregando una objeto Figura - no un string
        }
    }

    private void btnMostrarMas_Click(object sender, EventArgs e)
    {
        Figura seleccionada = lbxListaFiguras.SelectedItem as Figura;
        label1.Text = "";
        if (seleccionada != null)
        {
            if (seleccionada is Ortoedro)
            {
                Ortoedro aux = (Ortoedro)seleccionada;
                label1.Text = $"An:{aux.Ancho:f2} X Al:{aux.Alto:f2}";
            }
            else if (seleccionada is Cilindro)
            {
                Cilindro aux = (Cilindro)seleccionada;
                label1.Text = $"Rad:{aux.Radio:f2}";
            }
            label1.Text += seleccionada.Describir(); //comportamiento polimorfico!
        }
        else
        {
            label1.Text = "no ha seleccionado un objeto";
        }

    }

    private void btnOrdenarFiguras_Click(object sender, EventArgs e)
    {
        figuras.Sort();
    }
}
