using System.ComponentModel.DataAnnotations;

namespace Linter.Modelos
{
    public class Enumeradores
    {
        #region Dicas de uso 
        //pra usar os enumeradores em uma view, é preciso usar o código deste jeito 
        //Enum.GetNames(typeof(Enumeradores.TipoMovimentacao))
        //<FluentListbox Items = "Enum.GetNames(typeof(Enumeradores.TipoMovimentacao))" ></ FluentListbox >


        #endregion


        public enum SimNao
        {
            Sim = 0,
            Não = 1
        }
        public enum TipoMovimentacao
        {
            [Display(Name = "Entrada")]
            Entrada = 0,
            [Display(Name = "Saida")]
            Saída = 1
            //transferencia, troco, etc?
        }
        public enum TipoView
        {
            Criar = 0,
            Editar = 1,
            Apagar = 2,
            Exibir = 3
        }
        public enum TipoUsuario
        {
            Usuario = 0,
            Admin = 1
        }
        public enum Roles
        {
            Admin = 0,
            Usuario = 1
        }

        public enum Cidades
        {
            [Display(Name = "Aceguá")]
            Acegua = 0,
            [Display(Name = "Água Santa")]
            AguaSanta = 1,
            [Display(Name = "Agudo")]
            Agudo = 2,
            [Display(Name = "Ajuricaba")]
            Ajuricaba = 3,
            [Display(Name = "Alecrim")]
            Alecrim = 4,
            [Display(Name = "Alegrete")]
            Alegrete = 5,
            [Display(Name = "Alegria")]
            Alegria = 6,
            [Display(Name = "Almirante Tamandaré do Sul")]
            AlmiranteTamandareDoSul = 7,
            [Display(Name = "Alpestre")]
            Alpestre = 8,
            [Display(Name = "Alto Alegre")]
            AltoAlegre = 9,
            [Display(Name = "Alto Feliz")]
            AltoFeliz = 10,
            [Display(Name = "Alvorada")]
            Alvorada = 11,
            [Display(Name = "Amaral Ferrador")]
            AmaralFerrador = 12,
            [Display(Name = "Ametista do Sul")]
            AmetistaDoSul = 13,
            [Display(Name = "André da Rocha")]
            AndreDaRocha = 14,
            [Display(Name = "Anta Gorda")]
            AntaGorda = 15,
            [Display(Name = "Antônio Prado")]
            AntonioPrado = 16,
            [Display(Name = "Arambaré")]
            Arambare = 17,
            [Display(Name = "Araricá")]
            Ararica = 18,
            [Display(Name = "Aratiba")]
            Aratiba = 19,
            [Display(Name = "Arroio do Meio")]
            ArroioDoMeio = 20,
            [Display(Name = "Arroio do Padre")]
            ArroioDoPadre = 21,
            [Display(Name = "Arroio do Sal")]
            ArroioDoSal = 22,
            [Display(Name = "Arroio do Tigre")]
            ArroioDoTigre = 23,
            [Display(Name = "Arroio dos Ratos")]
            ArroioDosRatos = 24,
            [Display(Name = "Arroio Grande")]
            ArroioGrande = 25,
            [Display(Name = "Arvorezinha")]
            Arvorezinha = 26,
            [Display(Name = "Augusto Pestana")]
            AugustoPestana = 27,
            [Display(Name = "Áurea")]
            Aurea = 28,
            [Display(Name = "Bagé")]
            Bage = 29,
            [Display(Name = "Balneário Pinhal")]
            BalnearioPinhal = 30,
            [Display(Name = "Barão")]
            Barao = 31,
            [Display(Name = "Barão de Cotegipe")]
            BaraoDeCotegipe = 32,
            [Display(Name = "Barão do Triunfo")]
            BaraoDoTriunfo = 33,
            [Display(Name = "Barracão")]
            Barracao = 34,
            [Display(Name = "Barra do Guarita")]
            BarraDoGuarita = 35,
            [Display(Name = "Barra do Quaraí")]
            BarraDoQuarai = 36,
            [Display(Name = "Barra do Ribeiro")]
            BarraDoRibeiro = 37,
            [Display(Name = "Barra do Rio Azul")]
            BarraDoRioAzul = 38,
            [Display(Name = "Barra Funda")]
            BarraFunda = 39,
            [Display(Name = "Itaquaquicetuba")]
            Itaquaquicetuba = 40,
            [Display(Name = "Barros Cassal")]
            BarrosCassal = 41,
            [Display(Name = "Benjamin Constant do Sul")]
            BenjaminConstantDoSul = 42,
            [Display(Name = "Bento Gonçalves")]
            BentoGoncalves = 43,
            [Display(Name = "Boa Vista das Missões")]
            BoaVistaDasMissoes = 44,
            [Display(Name = "Boa Vista do Buricá")]
            BoaVistaDoBurica = 45,
            [Display(Name = "Boa Vista do Cadeado")]
            BoaVistaDoCadeado = 46,
            [Display(Name = "Boa Vista do Incra")]
            BoaVistaDoIncra = 47,
            [Display(Name = "Boa Vista do Sul")]
            BoaVistaDoSul = 48,
            [Display(Name = "Bom Jesus")]
            BomJesus = 49,
            [Display(Name = "Bom Princípio")]
            BomPrincipio = 50,
            [Display(Name = "Bom Progresso")]
            BomProgresso = 51,
            [Display(Name = "Bom Retiro do Sul")]
            BomRetiroDoSul = 52,
            [Display(Name = "Boqueirão do Leão")]
            BoqueiraoDoLeao = 53,
            [Display(Name = "Bossoroca")]
            Bossoroca = 54,
            [Display(Name = "Bozano")]
            Bozano = 55,
            [Display(Name = "Braga")]
            Braga = 56,
            [Display(Name = "Brochier")]
            Brochier = 57,
            [Display(Name = "Butiá")]
            Butia = 58,
            [Display(Name = "Caçapava do Sul")]
            CacapavaDoSul = 59,
            [Display(Name = "Cacequi")]
            Cacequi = 60,
            [Display(Name = "Cachoeira do Sul")]
            CachoeiraDoSul = 61,
            [Display(Name = "Cachoeirinha")]
            Cachoeirinha = 62,
            [Display(Name = "Cacique Doble")]
            CaciqueDoble = 63,
            [Display(Name = "Caibaté")]
            Caibate = 64,
            [Display(Name = "Caiçara")]
            Caicara = 65,
            [Display(Name = "Camaquã")]
            Camaqua = 66,
            [Display(Name = "Camargo")]
            Camargo = 67,
            [Display(Name = "Cambará do Sul")]
            CambaraDoSul = 68,
            [Display(Name = "Campestre da Serra")]
            CampestreDaSerra = 69,
            [Display(Name = "Campina das Missões")]
            CampinaDasMissoes = 70,
            [Display(Name = "Campinas do Sul")]
            CampinasDoSul = 71,
            [Display(Name = "Campo Bom")]
            CampoBom = 72,
            [Display(Name = "Campo Novo")]
            CampoNovo = 73,
            [Display(Name = "Campos Borges")]
            CamposBorges = 74,
            [Display(Name = "Candelária")]
            Candelaria = 75,
            [Display(Name = "Cândido Godói")]
            CandidoGodoi = 76,
            [Display(Name = "Candiota")]
            Candiota = 77,
            [Display(Name = "Canela")]
            Canela = 78,
            [Display(Name = "Canguçu")]
            Cangucu = 79,
            [Display(Name = "Canoas")]
            Canoas = 80,
            [Display(Name = "Canudos do Vale")]
            CanudosDoVale = 81,
            [Display(Name = "Capão Bonito do Sul")]
            CapaoBonitoDoSul = 82,
            [Display(Name = "Capão da Canoa")]
            CapaoDaCanoa = 83,
            [Display(Name = "Capão do Cipó")]
            CapaoDoCipo = 84,
            [Display(Name = "Capão do Leão")]
            CapaoDoLeao = 85,
            [Display(Name = "Capela de Santana")]
            CapelaDeSantana = 86,
            [Display(Name = "Capitão")]
            Capitao = 87,
            [Display(Name = "Capivari do Sul")]
            CapivariDoSul = 88,
            [Display(Name = "Caraá")]
            Caraa = 89,
            [Display(Name = "Carazinho")]
            Carazinho = 90,
            [Display(Name = "Carlos Barbosa")]
            CarlosBarbosa = 91,
            [Display(Name = "Carlos Gomes")]
            CarlosGomes = 92,
            [Display(Name = "Casca")]
            Casca = 93,
            [Display(Name = "Caseiros")]
            Caseiros = 94,
            [Display(Name = "Catuípe")]
            Catuipe = 95,
            [Display(Name = "Caxias do Sul")]
            CaxiasDoSul = 96,
            [Display(Name = "Centenário")]
            Centenario = 97,
            [Display(Name = "Cerrito")]
            Cerrito = 98,
            [Display(Name = "Cerro Branco")]
            CerroBranco = 99,
            [Display(Name = "Cerro Grande")]
            CerroGrande = 100,
            [Display(Name = "Cerro Grande do Sul")]
            CerroGrandeDoSul = 101,
            [Display(Name = "Cerro Largo")]
            CerroLargo = 102
            // Continue essa lista com as demais cidades...
        }





    }
}
