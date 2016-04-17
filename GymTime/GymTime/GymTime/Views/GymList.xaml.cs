using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymTime.Helpers;
using GymTime.Models;
using Xamarin.Forms;

namespace GymTime.Views
{
    public partial class GymList : ContentPage
    {
        private List<Gym> _gyms;
        public GymList()
        {
            InitializeComponent();

            #region dados temporários - deletar quando tiver base de dados
            this._gyms = new List<Gym>();
            this._gyms.Add(new Gym { Name = "Cristal Fitness", Address = "Avenida Wensceslau Escobar" });
            this._gyms.Add(new Gym { Name = "American Gym", Address = "Avenida Doutor Barcelos" });
            this._gyms.Add(new Gym { Name = "Pitbull Gym", Address = "Avenida Nonoai" });
            this._gyms.Add(new Gym { Name = "Extrema Força", Address = "Andradas" });
            this._gyms.Add(new Gym { Name = "Training Bom Fim", Address = "Rua Santana" });
            this._gyms.Add(new Gym { Name = "Power Fitness", Address = "Rua José de Alencar" });
            this._gyms.Add(new Gym { Name = "Ciclos Academia", Address = "Avenida Diário de Noticias" });
            this._gyms.Add(new Gym { Name = "Bio Express", Address = "Avenida Otto" });
            this._gyms.Add(new Gym { Name = "Bio Ativa", Address = "Padre Chagas" });
            this._gyms.Add(new Gym { Name = "Kratos", Address = "Nilo Peçanha" });
            this._gyms.Add(new Gym { Name = "Miudinho", Address = "Bento Gonçalves" });
            this._gyms.Add(new Gym { Name = "Vibração", Address = "Avenida Castelo Branco" });
            this._gyms.Add(new Gym { Name = "Active Fitness", Address = "Coronel Feijó" });
            this._gyms.Add(new Gym { Name = "Alternativa", Address = "Princesa Isabel" });
            this._gyms.Add(new Gym { Name = "Oxy Fitness", Address = "RUa Caldre Fião" });

            this.busca.TextChanged += Busca_TextChanged;
            this.lista.ItemsSource = this.Listar();
        }

        private void Busca_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.lista.ItemsSource = this.Listar(this.busca.Text);
        }

        public IEnumerable<Group<string, Gym>> Listar(string filtro = "")
        {
            IEnumerable<Gym> gymsFiltrados = this._gyms;
            if (!string.IsNullOrEmpty(filtro))
                gymsFiltrados = this._gyms.Where(l => (l.Name.ToLower().Contains(filtro.ToLower())) || l.Address.ToLower().Contains(filtro.ToLower()));

            return from livro in gymsFiltrados
                   orderby livro.Address
                   group livro by livro.Address into grupos
                   select new Group<string, Gym>(grupos.Key, grupos);

        }
        #endregion

    }
}