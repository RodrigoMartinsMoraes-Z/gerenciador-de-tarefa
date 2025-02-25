﻿using GerenciadorDeTarefas.Common.Models.Teams;

using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GerenciadorDeTarefas.Paginas.Equipes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNovaEquipe : ContentPage
    {
        private readonly IControleMenu _controleMenu = App.IoCConainer.GetInstance<IControleMenu>();

        public PaginaNovaEquipe()
        {
            InitializeComponent();

            Title = "Nova Equipe";

        }

        public async void AdicionarEquipe(object sender, EventArgs args)
        {
            TeamModel novaEquipe = new TeamModel { Nome = NomeEquipe.Text };

            App.User.Teams.Add(novaEquipe);
            //await App.Usuario.Salvar();

            await _controleMenu.AtualizarListaEquipes();
        }

        private void NomeEquipe_TextChanged(object sender, TextChangedEventArgs e)
        {
            NomeEquipeLbl.IsVisible = true;
        }
    }
}