using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


//Ordem sugerida para membros de uma classe:
/*
    - Atributos Privados
    - Propriedades Autoimplementadas
    - Construtores
    - Propriedades com Lógica
    - Métodos da classe
 */

namespace Course {
    internal class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
    }

}

    

