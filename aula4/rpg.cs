using System;
class program{

  static void Main(string[]args)
{
    Console.WriteLine("escolha uma classe (guerreira, mago ou arqueira)");
    string classe =Console.ReadLine();
        if(classe="guerreira"){
         Console.WriteLine("suas habilidades sao ataque pesado e defesa total");   
        } 
          else if(classe="mago"){
         Console.WriteLine("suas habilidades sao bola de fogoe escudo de gelo");   
        } 
          else if(classe="arqueira"){
         Console.WriteLine("suas habilidades sao flecha prescisa e disparo triplo");   
        }
        else
        {
            Console.WriteLine("voce nao selecionou nem uma classe valida");
        } 

}  

}