using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{



    public partial class Form1 : Form
    {
        int[] valto = new int[40];
        int[] vancho = new int[40];
        int[] valto1 = new int[40];
        int[] vancho1 = new int[40];
        int alto = 64;
        int ancho = 32;
        int marca = 0;
        int flag = 0;
        int marca1 = 0;
        int flag1 = 0;
        Random rnd = new Random();
        Bitmap bmp = new Bitmap(32, 64);
        Bitmap bmp1 = new Bitmap(32, 64);

        int tiro1 = 0;
        int averiado1 = 0;
        int agua1 = 0;
        int[] usadosX1 = new int[2060];
        int[] usadosY1 = new int[2060];
        int posicion1 = 0;

        int tiro2 = 0;
        int averiado2 = 0;
        int agua2 = 0;
        int aciertoX = 0;
        int aciertoY = 0;
        int[] usadosX2 = new int[2060];
        int[] usadosY2= new int[2060];
        int posicion2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public void generar_barcos(int size)
        {


            int y = rnd.Next(64);
            int x = rnd.Next(32);
            int direccion = rnd.Next(2);
            int checky = 0;
            int checkx = 0;
            
            while (y > (63 - size) && direccion == 0)
            {
                y = rnd.Next(64);
            }

            while (x > (31 - size) && direccion == 1)
            {
                x = rnd.Next(32);
            }


            if (flag == 1)
            {
                checky = y;
                checkx = x;

                for (int i = checky; i <= (checky + size); i++)
                {
                    for (int j = 0; j < valto.Length; j++)
                    {
                        if (valto[j] == checky && vancho[j] == checkx)
                        {
                            generar_barcos(size);
                            return;
                            /*y = rnd.Next(63);
                            while (y > (63 - size) && direccion == 0)
                            {
                                y = rnd.Next(63);
                            }*/

                        }

                    }
                }
                for (int i = checkx; i <= (checkx + size); i++)
                {
                    for (int j = 0; j < vancho.Length; j++)
                    {
                        if (vancho[j] == checkx && valto[j] == checky)
                        {
                            generar_barcos(size);
                            return;
                           /* x = rnd.Next(31);
                            while (x > (31 - size) && direccion == 1)
                            {
                                x = rnd.Next(31);
                            }*/
                        }

                    }
                }
            }


            valto[marca] = y;
            vancho[marca] = x;
            marca++;
            int temp = marca;

            for (int i = marca; i < (temp + (size - 1)); i++)
            {

                if (direccion == 0)
                {
                    y++;
                    valto[i] = y;
                    vancho[i] = x;
                    marca++;
                }
                else
                {
                    x++;
                    vancho[i] = x;
                    valto[i] = y;
                    marca++;
                }

            }
            flag = 1;
        }

        public void generar_barcos1(int size)
        {


            int y = rnd.Next(64);
            int x = rnd.Next(32);
            int direccion = rnd.Next(2);
            int checky = 0;
            int checkx = 0;

            while (y > (63 - size) && direccion == 0)
            {
                y = rnd.Next(64);
            }

            while (x > (31 - size) && direccion == 1)
            {
                x = rnd.Next(32);
            }


            if (flag1 == 1)
            {
                checky = y;
                checkx = x;

                for (int i = checky; i <= (checky + size); i++)
                {
                    for (int j = 0; j < valto1.Length; j++)
                    {
                        if (valto1[j] == checky && vancho1[j] == checkx)
                        {
                            generar_barcos(size);
                            return;
                            /*y = rnd.Next(63);
                            while (y > (63 - size) && direccion == 0)
                            {
                                y = rnd.Next(63);
                            }*/

                        }

                    }
                }
                for (int i = checkx; i <= (checkx + size); i++)
                {
                    for (int j = 0; j < vancho1.Length; j++)
                    {
                        if (vancho1[j] == checkx && valto1[j] == checky)
                        {
                            generar_barcos(size);
                            return;
                            /* x = rnd.Next(31);
                             while (x > (31 - size) && direccion == 1)
                             {
                                 x = rnd.Next(31);
                             }*/
                        }

                    }
                }
            }


            valto1[marca1] = y;
            vancho1[marca1] = x;
            marca1++;
            int temp = marca1;

            for (int i = marca1; i < (temp + (size - 1)); i++)
            {

                if (direccion == 0)
                {
                    y++;
                    valto1[i] = y;
                    vancho1[i] = x;
                    marca1++;
                }
                else
                {
                    x++;
                    vancho1[i] = x;
                    valto1[i] = y;
                    marca1++;
                }

            }
            flag1 = 1;
        }

        public void generar_barcos_main()
        {

            Array.Clear(valto, 0, 40);
            Array.Clear(vancho, 0, 40);
            marca = 0;
            flag = 0;
            Array.Clear(valto1, 0, 40);
            Array.Clear(vancho1, 0, 40);
            marca1 = 0;
            flag1 = 0;
            generar_barcos(2);
            generar_barcos(2);
            generar_barcos(3);
            generar_barcos(3);
            generar_barcos(4);
            generar_barcos(4);
            generar_barcos(5);
            generar_barcos(5);
            generar_barcos(6);
            generar_barcos(6);
            generar_barcos1(2);
            generar_barcos1(2);
            generar_barcos1(3);
            generar_barcos1(3);
            generar_barcos1(4);
            generar_barcos1(4);
            generar_barcos1(5);
            generar_barcos1(5);
            generar_barcos1(6);
            generar_barcos1(6);
        }
        public void llenar_bitmap_main()
        {
            //Bitmap bmp = new Bitmap(ancho, alto);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.Blue);
                }
            }

            for (int i = 0; i < valto.Length; i++)
            {
                bmp.SetPixel(vancho[i], valto[i], Color.Red);
            }

            Bitmap newImg = new Bitmap(320, 640);

            using (Graphics g = Graphics.FromImage(newImg))
                g.DrawImage(bmp, 0, 0, 320, 640);

            pictureBox1.Image = newImg;
            ///-----

            //Bitmap bmp1 = new Bitmap(ancho, alto);

            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    bmp1.SetPixel(i, j, Color.Blue);
                }
            }

            
            for (int i = 0; i < valto1.Length; i++)
            {
                bmp1.SetPixel(vancho1[i], valto1[i], Color.Black);
            }

            Bitmap newImg1 = new Bitmap(320, 640);

            using (Graphics g1 = Graphics.FromImage(newImg1))
                g1.DrawImage(bmp1, 0, 0, 320, 640);

            pictureBox2.Image = newImg1;
        }
        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            generar_barcos_main();
            llenar_bitmap_main();
            btnDisparo1.Enabled = true;
            btnDisparo2.Enabled = true;
            Btn_Generar.Enabled = false;
        }


        private void btnDisparo1_Click(object sender, EventArgs e)
        {
            if (comboJugador1.SelectedIndex == 0)
            {

                turno1();
            }

            btnDisparo1.Enabled = false;
            btnDisparo2.Enabled = true;
        }

        private void btnDisparo2_Click(object sender, EventArgs e)
        {

            if (comboJugador2.SelectedIndex == 0)
            {
                turno2();
            }
            else if (comboJugador2.SelectedIndex == 1)
            {
                estrategia2();
            }

            btnDisparo2.Enabled = false;
            btnDisparo1.Enabled = true;
        }

        public void turno1()
        {
            int cont = 0;
            int x = rnd.Next(32);
            int y = rnd.Next(64);

            // Controla que no repita un disparo
            for (int i = 0; i < usadosX1.Length; i++)
                if (x == usadosX1[i])
                {
                    for (int j = 0; j < usadosY1.Length; j++)
                        if (y == usadosY1[i])
                        {
                            turno1();
                            return;
                        }
                }

            for (int i = 0; i < vancho1.Length; i++)
            {
                if (x == vancho1[i])
                { 
                    if (y == valto1[i])
                        {
                            bmp1.SetPixel(x, y, Color.Gold);
                            averiado1 += 1;
                            cont += 1;
                            break;
                        }
                    
                }

            }

            if (cont == 0)
            {
                bmp1.SetPixel(x, y, Color.White);
                agua1 += 1;
            }

            Bitmap newImg1 = new Bitmap(320, 640);

            using (Graphics g1 = Graphics.FromImage(newImg1))
                g1.DrawImage(bmp1, 0, 0, 320, 640);

            pictureBox2.Image = newImg1;
            tiro1 += 1;

            usadosX1[posicion1] = x;
            usadosY1[posicion1] = y;

            posicion1++;

            lblTiro1.Text = Convert.ToString(tiro1);
            lblTiro1.Visible = true;
            lblAciertos1.Text = Convert.ToString(averiado1);
            lblAciertos1.Visible = true;
            lblAgua1.Visible = true;
            lblAgua1.Text = Convert.ToString(agua1);

        }

        public void turno2()
        {
            int cont = 0;
            int x = rnd.Next(0, 32);
            int y = rnd.Next(0, 64);

            // Controla que no repita un disparo
            for (int i = 0; i < usadosX2.Length; i++)
            {
                if (x == usadosX2[i])
                {
                    for (int j = 0; j < usadosY2.Length; j++)
                        if (y == usadosY2[i])
                        {
                            turno2();
                            return;
                        }
                }
            }
            for (int i = 0; i < vancho.Length; i++)
            {
                if (x == vancho[i])
                {
                   
                    if (y == valto[i])
                        {
                            bmp.SetPixel(x, y, Color.Gold);
                            averiado2 += 1;
                            cont += 1;
                            break;
                       }
                    
                }

            }

            if (cont == 0)
            {
                bmp.SetPixel(x, y, Color.White);
                agua2 += 1;
            }

            Bitmap newImg = new Bitmap(320, 640);

            using (Graphics g = Graphics.FromImage(newImg))
                g.DrawImage(bmp, 0, 0, 320, 640);

            pictureBox1.Image = newImg;
            tiro2 += 1;

            usadosX2[posicion2] = x;
            usadosY2[posicion2] = y;

            posicion2++;

            lblTiro2.Text = Convert.ToString(tiro2);
            lblTiro2.Visible = true;
            lblAciertos2.Text = Convert.ToString(averiado2);
            lblAciertos2.Visible = true;
            lblAgua2.Visible = true;
            lblAgua2.Text = Convert.ToString(agua2);

 
        }
           

        private void estrategia2()
        {
            
            int cont = 0;
            int x = rnd.Next(32);
            int y = rnd.Next(64);

         

            if (aciertoX != 0 && aciertoY == 0)
            {
                x = aciertoX;
            }
            else if (aciertoX != 0 && aciertoY != 0)
            {
                x = aciertoX + 1;
                y = aciertoY;

            }


            for (int i = 0; i < usadosX2.Length; i++)
            {
                if (x == usadosX2[i])
                {
                    for (int j = 0; j < usadosY2.Length; j++)
                        if (y == usadosY2[i])
                        {
                            estrategia2();
                            return;
                        }
                }
            }

            for (int i = 0; i < vancho.Length; i++)
            {
                if (x == vancho[i])
                {
                    aciertoX = x;
                  
                        if (y == valto[i])
                        {
                            bmp.SetPixel(x, y, Color.Gold);
                            averiado2 += 1;
                            aciertoY = y;
                            cont += 1;
                            break;
                        }
                    
                }

            }


            if (cont == 0)
            {
                bmp.SetPixel(x, y, Color.White);
                agua2 += 1;
                aciertoX = 0;
                aciertoY = 0;
                
            }
            
            
            Bitmap newImg = new Bitmap(320, 640);

            using (Graphics g = Graphics.FromImage(newImg))
                g.DrawImage(bmp, 0, 0, 320, 640);

            pictureBox1.Image = newImg;
            tiro2 += 1;

            usadosX2[posicion2] = x;
            usadosY2[posicion2] = y;

            posicion2++;

            lblTiro2.Text = Convert.ToString(tiro2);
            lblTiro2.Visible = true;
            lblAciertos2.Text = Convert.ToString(averiado2);
            lblAciertos2.Visible = true;
            lblAgua2.Visible = true;
            lblAgua2.Text = Convert.ToString(agua2);

        }

        public class Item
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Item> lista1 = new List<Item>();

            lista1.Add(new Item("Aleatoria", 1));


            comboJugador1.DisplayMember = "Name";
            comboJugador1.ValueMember = "Value";
            comboJugador1.DataSource = lista1;


            List<Item> lista2 = new List<Item>();

            lista2.Add(new Item("Aleatoria", 1));
            lista2.Add(new Item("Estrategia 1", 2));

            comboJugador2.DisplayMember = "Name";
            comboJugador2.ValueMember = "Value";
            comboJugador2.DataSource = lista2;



            //
            // Se asigna el evento para control el cambio de seleccion
            //
            comboJugador1.SelectedIndexChanged += new System.EventHandler(this.comboJugador1_SelectedIndexChanged);
            comboJugador2.SelectedIndexChanged += new System.EventHandler(this.comboJugador2_SelectedIndexChanged);

        }

        private void comboJugador1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboJugador2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
