using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoAdvinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instância da classe é criada.
            Configurações cfg = new Configurações();

            //Inicializa todos os métodos necessários.
            cfg.Iniciar_E_VerificarResp();
            cfg.Inserir_Valor();
            cfg.Verificar_Valores();
            cfg.Gerar_Numero();
            cfg.InciarJogo();

            Console.ReadKey(); //Aguarda o usuário pressionar uma tecla
        }  
    }
}
