using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcualdora_EDI
{
    public partial class Form1 : Form
    {

        // variables
        int metodo = 10;
        int textboxes = 0;
        int clicked = 0;
        double PI = 3.1415926535897931;

        // funciones
        private void volumen()
        {
            //textbox 1
            if (textBox1.TextLength != 0 && textBox11.TextLength != 0) // osea si la textbox no está vacia
            {
                // pasamos los numeros de la textbox a float
                float diam = float.Parse(textBox1.Text);
                float h = float.Parse(textBox11.Text);

                // hacemos la cuenta
                double vol = (PI * (diam * diam) * h) / 4;

                // mostramos el resultado
                res1.Text = vol.ToString();
            }

            //textbox 2
            if (textBox2.TextLength != 0 && textBox12.TextLength != 0)
            {
                float diam = float.Parse(textBox2.Text);
                float h = float.Parse(textBox12.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res2.Text = vol.ToString();
            }

            //textbox 3
            if (textBox3.TextLength != 0 && textBox13.TextLength != 0)
            {
                float diam = float.Parse(textBox3.Text);
                float h = float.Parse(textBox13.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res3.Text = vol.ToString();
            }

            //textbox 4
            if (textBox4.TextLength != 0 && textBox14.TextLength != 0)
            {
                float diam = float.Parse(textBox4.Text);
                float h = float.Parse(textBox14.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res4.Text = vol.ToString();
            }

            //textbox 5
            if (textBox5.TextLength != 0 && textBox15.TextLength != 0)
            {
                float diam = float.Parse(textBox5.Text);
                float h = float.Parse(textBox15.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res5.Text = vol.ToString();
            }

            //textbox 6
            if (textBox6.TextLength != 0 && textBox16.TextLength != 0)
            {
                float diam = float.Parse(textBox6.Text);
                float h = float.Parse(textBox16.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res6.Text = vol.ToString();
            }

            //textbox 7
            if (textBox7.TextLength != 0 && textBox17.TextLength != 0)
            {
                float diam = float.Parse(textBox7.Text);
                float h = float.Parse(textBox17.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res7.Text = vol.ToString();
            }

            //textbox 8
            if (textBox8.TextLength != 0 && textBox18.TextLength != 0)
            {
                float diam = float.Parse(textBox8.Text);
                float h = float.Parse(textBox18.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res8.Text = vol.ToString();
            }

            //textbox 9
            if (textBox9.TextLength != 0 && textBox19.TextLength != 0)
            {
                float diam = float.Parse(textBox9.Text);
                float h = float.Parse(textBox19.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res9.Text = vol.ToString();
            }

            //textbox 10
            if (textBox10.TextLength != 0 && textBox20.TextLength != 0)
            {
                float diam = float.Parse(textBox10.Text);
                float h = float.Parse(textBox20.Text);
                double vol = (PI * (diam * diam) * h) / 4;

                res10.Text = vol.ToString();
            }
        }

        private void arquimedes()
        {
            //textbox 1
            if (textBox1.TextLength != 0 && textBox11.TextLength != 0) // osea si la textbox no está vacia
            {
                // pasamos los numeros de la textbox a float
                float volI = float.Parse(textBox1.Text);
                float volF = float.Parse(textBox11.Text);

                // hacemos la cuenta
                double vol = volF - volI;

                // mostramos el resultado
                res1.Text = vol.ToString();
            }

            //textbox 2
            if (textBox2.TextLength != 0 && textBox12.TextLength != 0)
            {

                float volI = float.Parse(textBox2.Text);
                float volF = float.Parse(textBox12.Text);

                double vol = volF - volI;

                res2.Text = vol.ToString();
            }

            //textbox 3
            if (textBox3.TextLength != 0 && textBox13.TextLength != 0)
            {

                float volI = float.Parse(textBox3.Text);
                float volF = float.Parse(textBox13.Text);

                double vol = volF - volI;

                res3.Text = vol.ToString();
            }

            //textbox 4
            if (textBox4.TextLength != 0 && textBox14.TextLength != 0)
            {

                float volI = float.Parse(textBox4.Text);
                float volF = float.Parse(textBox14.Text);

                double vol = volF - volI;

                res4.Text = vol.ToString();
            }

            //textbox 5
            if (textBox5.TextLength != 0 && textBox15.TextLength != 0)
            {

                float volI = float.Parse(textBox5.Text);
                float volF = float.Parse(textBox15.Text);

                double vol = volF - volI;

                res5.Text = vol.ToString();
            }

            //textbox 6
            if (textBox6.TextLength != 0 && textBox16.TextLength != 0)
            {

                float volI = float.Parse(textBox6.Text);
                float volF = float.Parse(textBox16.Text);

                double vol = volF - volI;

                res6.Text = vol.ToString();
            }

            //textbox 7
            if (textBox7.TextLength != 0 && textBox17.TextLength != 0)
            {

                float volI = float.Parse(textBox7.Text);
                float volF = float.Parse(textBox17.Text);

                double vol = volF - volI;

                res7.Text = vol.ToString();
            }

            //textbox 8
            if (textBox8.TextLength != 0 && textBox18.TextLength != 0)
            {

                float volI = float.Parse(textBox8.Text);
                float volF = float.Parse(textBox18.Text);

                double vol = volF - volI;

                res8.Text = vol.ToString();
            }

            //textbox 9
            if (textBox9.TextLength != 0 && textBox19.TextLength != 0)
            {

                float volI = float.Parse(textBox9.Text);
                float volF = float.Parse(textBox19.Text);

                double vol = volF - volI;

                res9.Text = vol.ToString();
            }

            //textbox 10
            if (textBox10.TextLength != 0 && textBox20.TextLength != 0)
            {

                float volI = float.Parse(textBox10.Text);
                float volF = float.Parse(textBox20.Text);

                double vol = volF - volI;

                res10.Text = vol.ToString();
            }
        }

        private void calcPromedio()
        {
            float promedioTotal = 0;
            float promedioCalculado = 0;
            int respuestasVisible = 0;
            float respuesta1 = 0;
            float respuesta2 = 0;
            float respuesta3 = 0;
            float respuesta4 = 0;
            float respuesta5 = 0;
            float respuesta6 = 0;
            float respuesta7 = 0;
            float respuesta8 = 0;
            float respuesta9 = 0;
            float respuesta10 = 0;

            //averiguamos que no esten las textbox vacias y pasamos su contenido a float
            if (res1.TextLength != 0) { respuesta1 = float.Parse(res1.Text); }
            if (res2.TextLength != 0) { respuesta2 = float.Parse(res2.Text); }
            if (res3.TextLength != 0) { respuesta3 = float.Parse(res3.Text); }
            if (res4.TextLength != 0) { respuesta4 = float.Parse(res4.Text); }
            if (res5.TextLength != 0) { respuesta5 = float.Parse(res5.Text); }
            if (res6.TextLength != 0) { respuesta6 = float.Parse(res6.Text); }
            if (res7.TextLength != 0) { respuesta7 = float.Parse(res7.Text); }
            if (res8.TextLength != 0) { respuesta8 = float.Parse(res8.Text); }
            if (res9.TextLength != 0) { respuesta9 = float.Parse(res9.Text); }
            if (res10.TextLength != 0) { respuesta10 = float.Parse(res10.Text); }

            //averiguamos cuantas respuestas hay y sumamos la respuesta
            if (res1.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta1;
            }
            if (res2.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta2;
            }
            if (res3.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta3;
            }
            if (res4.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta4;
            }
            if (res5.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta5;
            }
            if (res6.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta6;
            }
            if (res7.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta7;
            }
            if (res8.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta8;
            }
            if (res9.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta9;
            }
            if (res10.Visible == true)
            {
                respuestasVisible++;
                promedioTotal = promedioTotal + respuesta10;
            }

            //hacemos la cuenta
            promedioCalculado = promedioTotal / respuestasVisible;

            //mostramos el promedio
            textPromedio.Text = promedioCalculado.ToString();
            
        }

        // clicks
        private void casoA_Click(object sender, EventArgs e)
        {
            metodo = 0; // establece q se selecciono el caso A

            showCantidades(); // muestra las opciones para la cantidad de calculos



            clearTextbox(); // vaciamos las textboxs

            if (clicked > 0)
            {
                textoMetodo.Show();
                textoMetodo.Text = "Introduzca el diametro y la altura de cada caso";
            }
        }

        private void casoB_Click(object sender, EventArgs e)
        {
            metodo = 1; // estableces q se selecciono el caso B

            showCantidades(); // muestra las opciones para la cantidad de calculos

            clearTextbox(); // limpiamos las textboxs

            if (clicked > 0)
            {
                textoMetodo.Show();
                textoMetodo.Text = "Introduzca el volumen inicial y final de cada caso";
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (cantidad.TextLength != 0) //confirmamos que no esta vacio la textbox
            {
                textboxes = Int32.Parse(cantidad.Text); // pasamos a limpio la cantidad de calculos a realizar
            }
            else
            {
                MessageBox.Show("Por favor ingresar un numero");
            }

            if (textboxes > 10) // mostramos error si el num es mayor a 10
            {
                MessageBox.Show("Por favor no ingrese un numero mayor a 10.");
            }
            else
            {
                clicked++; // hacemos saber que el boton agregar se presionó

                calcular.Show();
                showTextbox(); // mostramos todas las textboxs

                // mostrar el texto del caso A
                if (metodo == 0)
                {
                    textoMetodo.Show();
                    textoMetodo.Text = "Introduzca el diametro y la altura de cada caso";
                }
                else if (metodo == 1) // mostrar el texto del caso B
                {
                    textoMetodo.Show();
                    textoMetodo.Text = "Introduzca el volumen inicial y final de cada caso";
                }
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            promediar.Show();

            // averiguamos q caso se eligió (0 volumen, 1 arquimedes)
            if (metodo == 0) 
            {
                volumen();
            }
            else if (metodo == 1)
            {
                arquimedes();
            }
        }

        private void promediar_Click(object sender, EventArgs e)
        {
            label4.Show();
            textPromedio.Show();

            calcPromedio();
        }

        private void shutoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //extras
        private void showCantidades()
        {
            label3.Show();
            cantidad.Show();
            agregar.Show();
        }

        private void showTextbox()
        {
            // reinicio de textboxs y cositas
            if (clicked > 0)
            {
                hideTextbox();
            }

            // mostrar textboxes y cositas
            if (textboxes >= 1) { textBox1.Show(); textBox11.Show(); res1.Show(); label16.Show(); }
            if (textboxes >= 2) { textBox2.Show(); textBox12.Show(); res2.Show(); label17.Show(); }
            if (textboxes >= 3) { textBox3.Show(); textBox13.Show(); res3.Show(); label18.Show(); }
            if (textboxes >= 4) { textBox4.Show(); textBox14.Show(); res4.Show(); label19.Show(); }
            if (textboxes >= 5) { textBox5.Show(); textBox15.Show(); res5.Show(); label20.Show(); }
            if (textboxes >= 6) { textBox6.Show(); textBox16.Show(); res6.Show(); label21.Show(); }
            if (textboxes >= 7) { textBox7.Show(); textBox17.Show(); res7.Show(); label22.Show(); }
            if (textboxes >= 8) { textBox8.Show(); textBox18.Show(); res8.Show(); label23.Show(); }
            if (textboxes >= 9) { textBox9.Show(); textBox19.Show(); res9.Show(); label24.Show(); }
            if (textboxes >= 10) { textBox10.Show(); textBox20.Show(); res10.Show(); label25.Show(); }
        }

        private void hideTextbox()
        {
            // oculta todas las textbox y cositas para el reincio de textboxes en el cambio de caso
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            textBox11.Hide();
            textBox12.Hide();
            textBox13.Hide();
            textBox14.Hide();
            textBox15.Hide();
            textBox16.Hide();
            textBox17.Hide();
            textBox18.Hide();
            textBox19.Hide();
            textBox20.Hide();

            res1.Hide();
            res2.Hide();
            res3.Hide();
            res4.Hide();
            res5.Hide();
            res6.Hide();
            res7.Hide();
            res8.Hide();
            res9.Hide();
            res10.Hide();

            label16.Hide();
            label17.Hide();
            label18.Hide();
            label19.Hide();
            label20.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
        }

        private void clearTextbox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();

            res1.Clear();
            res2.Clear();
            res3.Clear();
            res4.Clear();
            res5.Clear();
            res6.Clear();
            res7.Clear();
            res8.Clear(); 
            res9.Clear();
            res10.Clear();
        }


        // form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void res1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
