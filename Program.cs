using System;

namespace ConsoleWhatsapp {
    class Program {

        static void Main (string[] args) {
            Contato _contato = new Contato ();
            Agenda agd = new Agenda ();
            _contato.Nome = "Vash o estouro da boiada";
            _contato.Telefone = "4325-4576";
            agd.Cadastrar (_contato);
            agd.Listar ();
        }
    }
}