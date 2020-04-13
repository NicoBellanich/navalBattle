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
    public partial class Form2 : Form
    {

        int[] valto = new int[40];
        int[] vancho = new int[40];
        int[] valto1 = new int[40];
        int[] vancho1 = new int[40];
        int marca = 0;
        Random rnd = new Random();
        int flag = 0;

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




        public Form2()
        {
            InitializeComponent();
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
                            generar_barcos1(size);
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
                            generar_barcos1(size);
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

        public void generar_barcos2(int size)
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
                    for (int j = 0; j < valto1.Length; j++)
                    {
                        if (valto1[j] == checky && vancho1[j] == checkx)
                        {
                            generar_barcos2(size);
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
                            generar_barcos2(size);
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


            valto1[marca] = y;
            vancho1[marca] = x;
            marca++;
            int temp = marca;

            for (int i = marca; i < (temp + (size - 1)); i++)
            {

                if (direccion == 0)
                {
                    y++;
                    valto1[i] = y;
                    vancho1[i] = x;
                    marca++;
                }
                else
                {
                    x++;
                    vancho1[i] = x;
                    valto1[i] = y;
                    marca++;
                }

            }
            flag = 1;
        }
        private void jugador1()
        {

            Array.Clear(valto, 0, 40);
            Array.Clear(vancho, 0, 40);
            marca = 0;
            flag = 0;

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

        private void jugador2()
        {

            Array.Clear(valto1, 0, 40);
            Array.Clear(vancho1, 0, 40);
            marca = 0;
            flag = 0;

            generar_barcos2(2);
            generar_barcos2(2);
            generar_barcos2(3);
            generar_barcos2(3);
            generar_barcos2(4);
            generar_barcos2(4);
            generar_barcos2(5);
            generar_barcos2(5);
            generar_barcos2(6);
            generar_barcos2(6);
        }


        private void turno1()
        {
            
            int x = rnd.Next(32);
            int y = rnd.Next(64);
            
            for (int i = 0; i < vancho1.Length; i++)
            {
                if (x == vancho1[i])
                {
                    
                        if (y == valto1[i])
                        {
                            averiado1 += 1;
                            
                            tiro1 += 1;
                            return;
                        }
                    
                }
                
            }

           
                agua1 += 1;
         
            tiro1 += 1;
        }

        public void turno2()
        {
            int x = rnd.Next(32);
            int y = rnd.Next(64);

            for (int i = 0; i < vancho.Length; i++)
            {
                if (x == vancho[i])
                {
                    
                        if (y == valto[i])
                        {
                            averiado2 += 1;
                            tiro2 += 1;
                            return;
                        }
                    
                }
                
            }

           
            
            agua2 += 1;
            

            tiro2 += 1;
        }


        private void btnAutomatico_Click(object sender, EventArgs e)
        {
            btnAutomatico.Enabled = false;

            int gano1 = 0;
            int gano2 = 0;
            int cantidadJuegos = 0;
            int averiado1Total = 0;
            int averiado2Total = 0;
            //jugador1();
            //jugador2();

            while (cantidadJuegos < 1000)
            {

                jugador1();
                jugador2();


                while (averiado1 < 40 && averiado2 < 40)
                {

                    if (comboJugador1.SelectedIndex == 0)
                    {
                        turno1();
                    }

                    if (comboJugador2.SelectedIndex == 0)
                    {
                        turno2();
                    }
                    else if (comboJugador2.SelectedIndex == 1)
                    {
                        estrategia2();
                    }

                  
                }

                if (averiado1 == 40)
                {
                    gano1 += 1;

                }
                else
                {
                    gano2 += 1;
                }


                averiado1Total += averiado1;
                averiado2Total += averiado2;

                averiado1 = 0;
                averiado2 = 0;
                cantidadJuegos += 1;

            }

            //Simula un solo Juego
            //while (averiado1 < 40 && averiado2 < 40)
            //{
            //    turno1();
            //    turno2();
            //}

            //if (averiado1 == 40)
            //{
            //    gano1 += 1;
            //    cantidadJuegos += 1;
            //}
            //else
            //{
            //    gano2 += 1;
            //    cantidadJuegos += 1;
            //}


            lblTiro1.Text = Convert.ToString(tiro1);
            lblTiro1.Visible = true;
            lblAciertos1.Text = Convert.ToString(averiado1Total);
            lblAciertos1.Visible = true;
            lblAgua1.Visible = true;
            lblAgua1.Text = Convert.ToString(agua1);
            lblGano1.Visible = true;
            lblGano1.Text = Convert.ToString(gano1);

            lblTiro2.Text = Convert.ToString(tiro2);
            lblTiro2.Visible = true;
            lblAciertos2.Text = Convert.ToString(averiado2Total);
            lblAciertos2.Visible = true;
            lblAgua2.Visible = true;
            lblAgua2.Text = Convert.ToString(agua2);
            lblGano2.Visible = true;
            lblGano2.Text = Convert.ToString(gano2);

            lblCantPartidas.Visible = true;
            lblCantPartidas.Text = Convert.ToString(cantidadJuegos);

            btnAutomatico.Enabled = true;

        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Array.Clear(valto, 0, 40);
            Array.Clear(vancho, 0, 40);
            Array.Clear(valto1, 0, 40);
            Array.Clear(vancho1, 0, 40);
            marca = 0;
            flag = 0;
            marca = 0;

            lblTiro1.Text = "";
            lblTiro1.Visible = false;
            lblAciertos1.Text = "";
            lblAciertos1.Visible = false;
            lblAgua1.Visible = false;
            lblAgua1.Text = "";
            lblGano1.Visible = false;
            lblGano1.Text = "";

            lblTiro2.Text = "";
            lblTiro2.Visible = false;
            lblAciertos2.Text = "";
            lblAciertos2.Visible = false;
            lblAgua2.Visible = false;
            lblAgua2.Text = "";
            lblGano2.Visible = false;
            lblGano2.Text = "";

            lblCantPartidas.Visible = false;
            lblCantPartidas.Text = "";
        }


        private void estrategia2()
        {
            int x = rnd.Next(32);
            int y = rnd.Next(64);

            if (aciertoX != 0 && aciertoY == 0)
            {
                x = aciertoX;            
            }
            else if(aciertoX !=0 && aciertoY != 0)
            {
                x = aciertoX + 1;
                y = aciertoY;

            }
            

            for (int i = 0; i < vancho.Length; i++)
            {
                if (x == vancho[i])
                {
                    aciertoX = x;
                   
                    
                        if (y == valto[i])
                        {
                            averiado2 += 1;
                            aciertoY = y;
                            tiro2 += 1;
                            return;
                        }
                    
                }
                
            }

            agua2 += 1;
            aciertoX = 0;
            aciertoY = 0;
            tiro2 += 1;

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


        private void btnSemiAutomatico_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();
        }




        private void Form2_Load(object sender, EventArgs e)
        {
            btnAutomatico.Enabled = false;

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
            btnAutomatico.Enabled = true;
        }
    }

    
}
