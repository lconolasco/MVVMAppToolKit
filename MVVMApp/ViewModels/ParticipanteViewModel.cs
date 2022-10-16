using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMApp.Models;
using System.Collections.ObjectModel;

namespace MVVMApp.ViewModels
{
    public partial class ParticipanteViewModel : BaseViewModel
    {
        [ObservableProperty]
        private int id;

        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private string sobrenome;

        [ObservableProperty]
        private ParticipanteModel pessoaGanhadora;

        [ObservableProperty]
        private string messagem;

        public ObservableCollection<ParticipanteModel> Participantes { get; } = new();

        public ParticipanteViewModel()
        {
            Title = "MKN Sorteios";

        }

        [RelayCommand]
        private void IncluirNome()
        {
            try
            {
                if(string.IsNullOrEmpty(nome))
                {
                    Messagem = "O Campo nome é requerido.";
                    
                    return;
                }
                ParticipanteModel participanteModel = new();
                
                id = Participantes.Count;
                participanteModel.Id = id;
                participanteModel.Nome = nome;
                participanteModel.Sobrenome = Sobrenome;
                Participantes.Add(participanteModel);           
                Nome = String.Empty;
                Sobrenome=String.Empty;
                return;
            }
            catch (Exception ex) 
            {
                AppShell.Current.DisplayAlert("Error", $"Erro no inserimento dados. Error: {ex.Message}","Ok");
            }
            
        }

        [RelayCommand]
        private void Sortear()
        {
            try 
            {
                Random.Shared.Next(0, Participantes.Count);
                var indice = Random.Shared.Next(0, Participantes.Count);
                pessoaGanhadora = Participantes[indice];
                AppShell.Current.DisplayAlert($"Parabéns {pessoaGanhadora.Nome} {pessoaGanhadora.Sobrenome}!!!","Voce foi o GANHADOR desta rodada!","Ok");
                Participantes.Remove(Participantes[indice]);
                return;

            }
            catch(Exception ex)
            {
                Messagem = $"Impossivel realizar o sorteio. Erro: Lista vazia.";
                AppShell.Current.DisplayAlert("Erro", ex.Message, "Ok");
            }
            
        }

        [RelayCommand]
        private void CorrigirNome(ParticipanteModel participante)
        {
            try
            {
                if(Participantes.Contains(participante))
                {
                    foreach(ParticipanteModel participanteModel in Participantes)
                    {
                        Nome=String.Empty;
                        Sobrenome=String.Empty;

                        Nome=participanteModel.Nome;
                        Sobrenome=participanteModel.Sobrenome;
                        Participantes.Remove(participante);
                        return;
                    }
                }
                else
                {
                    AppShell.Current.DisplayAlert("Erro.", "Nenhum participante selecionado.", "Ok");
                }
            }
            catch(Exception ex)
            {
                AppShell.Current.DisplayAlert("Erro.", $"Impossivel editar dados do participante. Erro: {ex.Message}", "Ok");
            }
        }

        [RelayCommand]
        private void RemoverNome(ParticipanteModel participante)
        {
            try
            {
                if (Participantes.Contains(participante))
                {
                    Participantes.Remove(participante);
                    return ;
                }
                else
                {
                    Messagem = "Impossivel remover o participante selecionado";
                }
            }
            catch(Exception ex)
            {
                Messagem = "Impossivel remover participante. Este nao foi selecioando ou é inexistente.";
                AppShell.Current.DisplayAlert("Erro:", $"{Messagem} Erro: {ex.Message}", "OK");
            }

        }
    }
}
