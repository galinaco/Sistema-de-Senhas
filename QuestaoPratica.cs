using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Prova1
    {
        public abstract class Usuario
        {
            string Nomeusuario { get; set; }
            string Sobrenomeusuario { get; set; }
            string Senha { get; set; }
            public Usuario(string nomeusuario, string senha)
            {
                Nomeusuario = nomeusuario;
                Senha  =senha ;
            }
            public abstract void  checkamaiscula(string s,bool c, ref bool ap,ref bool maiap);
               
            public abstract void checkaminuscula(string s, bool c, ref bool ap, ref bool minap);

            public abstract void checkanumero(string s,bool c, ref bool ap, ref bool numap);

            public abstract void checkaespecial(string s, bool c, ref bool ap, ref bool espap);

            public abstract void checkatamanho(string s, bool c,ref bool ap, ref bool tamap);

            

            
        }

        public class UsuarioBanco : Usuario
        { 
            public UsuarioBanco(string nomeusuario,string senha): base(nomeusuario,senha)
            {
            }

            public virtual void username(string n)
            {
                Console.Write("Digite seu nome:");
                n = Console.ReadLine();

            }
            public virtual void username(string n, string sn)
            {
                Console.Write("Digite seu nome:");
                n = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite seu último sobrenome:");
                sn = Console.ReadLine();
            }
            public override void checkamaiscula(string s,bool c, ref bool ap, ref bool maiap) 
            {
                string[] alfabetomaisculo = new string[26];

                alfabetomaisculo[0] = "A";
                alfabetomaisculo[1] = "B";
                alfabetomaisculo[2] = "C";
                alfabetomaisculo[3] = "D";
                alfabetomaisculo[4] = "E";
                alfabetomaisculo[5] = "F";
                alfabetomaisculo[6] = "G";
                alfabetomaisculo[7] = "H";
                alfabetomaisculo[8] = "I";
                alfabetomaisculo[9] = "J";
                alfabetomaisculo[10] = "K";
                alfabetomaisculo[11] = "L";
                alfabetomaisculo[12] = "M";
                alfabetomaisculo[13] = "N";
                alfabetomaisculo[14] = "O";
                alfabetomaisculo[15] = "P";
                alfabetomaisculo[16] = "Q";
                alfabetomaisculo[17] = "R";
                alfabetomaisculo[18] = "S";
                alfabetomaisculo[19] = "T";
                alfabetomaisculo[20] = "U";
                alfabetomaisculo[21] = "V";
                alfabetomaisculo[22] = "W";
                alfabetomaisculo[23] = "X";
                alfabetomaisculo[24] = "Y";
                alfabetomaisculo[25] = "Z";

                for (int i = 0; i < alfabetomaisculo.Length; i++)
                {
                    bool b = s.Contains(alfabetomaisculo[i]);
                    if (b == true)
                    {
                        c = true;
                    }
                }
                if (c == true)
                {
                    
                }
                else
                {
                    
                    ap=false;
                    maiap=false;
                }
            }
            public override void checkaminuscula(string s, bool c,ref bool ap, ref bool minap)
            {
                string[] alfabetominusculo = new string[26];

                alfabetominusculo[0] = "a";
                alfabetominusculo[1] = "b";
                alfabetominusculo[2] = "c";
                alfabetominusculo[3] = "d";
                alfabetominusculo[4] = "e";
                alfabetominusculo[5] = "f";
                alfabetominusculo[6] = "g";
                alfabetominusculo[7] = "h";
                alfabetominusculo[8] = "i";
                alfabetominusculo[9] = "j";
                alfabetominusculo[10] = "k";
                alfabetominusculo[11] = "l";
                alfabetominusculo[12] = "m";
                alfabetominusculo[13] = "n";
                alfabetominusculo[14] = "o";
                alfabetominusculo[15] = "p";
                alfabetominusculo[16] = "q";
                alfabetominusculo[17] = "r";
                alfabetominusculo[18] = "s";
                alfabetominusculo[19] = "t";
                alfabetominusculo[20] = "u";
                alfabetominusculo[21] = "v";
                alfabetominusculo[22] = "w";
                alfabetominusculo[23] = "x";
                alfabetominusculo[24] = "y";
                alfabetominusculo[25] = "z";

                for (int i = 0; i < alfabetominusculo.Length; i++)
                {
                    bool b = s.Contains(alfabetominusculo[i]);
                    if (b == true)
                    {
                        c = true;
                    }
                }
                if (c == true)
                {
                   
                }
                else
                {
                    
                    ap = false;
                    minap = false;
                }
            }
            public override void checkanumero(string s, bool c, ref bool ap, ref bool numap)
            {
                string[] numeros = new string[10];
                numeros[0] = "0";
                numeros[1] = "1";
                numeros[2] = "2";
                numeros[3] = "3";
                numeros[4] = "4";
                numeros[5] = "5";
                numeros[6] = "6";
                numeros[7] = "7";
                numeros[8] = "8";
                numeros[9] = "9";

                for (int i = 0; i < numeros.Length; i++)
                {
                    bool b = s.Contains(numeros[i]);
                    if (b == true)
                    {
                        c = true;
                    }
                }
                if (c == true)
                {
                    
                }
                else
                {
                   
                    ap =false;
                    numap = false;
                }

            }
            public override void checkaespecial(string s, bool c, ref bool ap, ref bool espap)
            {
                char[] a = s.ToCharArray();
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsLetterOrDigit(a[i])== false)
                    {
                        c = true;
                    }

                }
                if (c == true)
                {
                    
                }
                else
                {
                    
                    ap = false;
                    espap = false;
                }
            }
            public override void checkatamanho(string s, bool c, ref bool ap, ref bool tamap)
            {
                int tamanho=0;
                char[] a = s.ToCharArray();
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsLetterOrDigit(a[i]) == true)
                    {
                        c = true;
                    }
                    else
                    {
                        c = false;
                    }
                    if(c==true)
                    {
                        tamanho= tamanho + 1;
                    }
                }
                if (tamanho>=8)
                { 
                
                }
                else
                {
                    
                    ap = false;
                    tamap = false;
                }
                
            }
        }
        static void Main(string[] args)
        {
            string nome="", senha="",sobrenome="";
            int escolhausuario = 3;
            bool check=false,senhaaprovada=true,masaprov=true,minaprov=true,numaprov=true,espaprov=true,tamaprov=true;
            Console.WriteLine("Olá usuario, gostaria de entrar só com seu primeiro nome ou nome e último sobrenome?");
            Console.WriteLine();
         
            UsuarioBanco a = new UsuarioBanco(nome, senha);
            
            while (escolhausuario != 1 && escolhausuario != 2)
            {
                Console.WriteLine("Digite 1 para somente primeiro nome ou 2 para nome e sobrenome");
                escolhausuario = int.Parse(Console.ReadLine());
                if (escolhausuario==1)
                {
                    a.username(nome);
                }
                else if(escolhausuario==2)
                {
                    a.username(nome,sobrenome);
                }
                else 
                {
                    Console.WriteLine("Escolha invalida");
                    
                }
            } 
          
             
            Console.Write("Senha: ");
            
            do {
                senha = Console.ReadLine();
                senhaaprovada = true;
                masaprov = true; 
                minaprov = true; 
                numaprov = true; 
                espaprov = true; 
                tamaprov = true;
                a.checkaminuscula(senha, check,ref senhaaprovada,ref minaprov);
                a.checkamaiscula(senha, check,ref  senhaaprovada,ref masaprov);
                a.checkanumero(senha, check, ref senhaaprovada,ref numaprov);
                a.checkaespecial(senha, check,ref senhaaprovada,ref espaprov);
                a.checkatamanho(senha, check,ref senhaaprovada, ref tamaprov);
                if(senhaaprovada==false)
                {
                    Console.WriteLine("Sua senha foi reprovada pelos motivos abaixo, por favor, insira uma senha valida");
                    if(masaprov==false)
                    {
                        Console.WriteLine("Sua senha não possui uma letra maiuscula");
                    }
                    if(minaprov==false)
                    {
                        Console.WriteLine("Sua senha não possui uma letra minuscula");
                    }
                    if (numaprov==false)
                    {
                        Console.WriteLine("Sua senha não possui um número");
                    }
                    if(espaprov== false)
                    {
                        Console.WriteLine("Sua senha não possui um caracter especial");
                    }
                    if(tamaprov==false)
                    {
                        Console.WriteLine("Sua senha não tem uma quantidade suficiente de caracteres alfanuméricos");
                    }
                    
              
                }
                else
                {
                    Console.WriteLine("Sua senha é valida");
                }
            } while (senhaaprovada==false);
            Console.ReadLine();
            
        }

    }


       
    
}
