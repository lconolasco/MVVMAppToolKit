# MVVMApp
  Esta app é baseada na live do MKN - Monkey Nights do dia 19/08/2022, onde Angelo Belchior apresentou demonstrou o uso da lib
CommunityToolkit.Mvvm desenvolvido pela communidade do .NET Community Toolkit que é mantida e publicada pela Microsoft.
  Ao longo da live foi lançado um "concurso" (# obvio que é uma brincadeira, que decidi e pedi para participar #) para integar melhorias no visual e novas funcionalidades.
  Existe um fork do repositorio do Angelo Belchior e um Pull Request deste App. Naquele repositorio é tem uma versao com algumas melhorias e funcionalidades, neste, O App seguirà um percurso mais aprofundido, com mais funcionalidades de acordo com um Road Map que serà detalhado neste documento. 

O que é .NET Community Toolkit?
  O .NET Community Toolkit é uma coleção de auxiliares e APIs que funcionam para todos os desenvolvedores .NET e são independentes de qualquer plataforma de interface do usuário específica. O kit de ferramentas é mantido e publicado pela Microsoft e faz parte da .NET Foundation.

Web Site
  Para maiores informaçoes, segue o link da comunidade.
    https://docs.microsoft.com/dotnet/communitytoolkit/?WT.mc_id=dotnet-0000-bramin
    
GitHub
    https://github.com/CommunityToolkit/dotnet
    
Disclaimer
  Os codigos aqui postados sao baseados nos mais diversos tutoriais vistos pela internet estudados e implementados de acordo com as minhas necessidade de aprendizagem. Logo, nao é garantido a segurança, funcionalidade e insençao de bugs, sejam estes explicitos ou implicitos. E nem é um produto comercializavel.
# Road Map
    1a. fase
        Modificaçoes no visual do App, melhorias na experiencia de usuario tais como o deslocamento do cursor de uma caixa de entrada para outra apos a concluçao da inserçao de um dado.
        Nesta fase foram feitas as seguintes alteraçoes:
        
    Realizado melhorias no UI com mudanças na paleta de cores dos controles, caixas de texto e etiquetas.
    
    Foi adicionado açoes no front end com a intençao de melhorar o UX. Apòs o inserimento do nome e clicando no botao enviar do teclando virtual do celular, o cursor vai para o campo de sobrenome. E apòs o inserimento do sobrenome e clicando no botao enviar, ele insere os dados na lista. A label "lblMessage" é usada pra exibiçao de erros ocorridos durante as operaçoes de inserimento e sorteio no App.

    Back end - Apòs o sorteio, o nome do ganhador serà retirado da lista e serà apresentado em um pop-up modal.
    
    2a. fase
		Serà implementado CRUD na CollectionView.            
