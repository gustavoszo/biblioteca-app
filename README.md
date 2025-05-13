# Programa para locadora de livros
 
O projeto é um aplicativo desenvolvido em Windows Forms para auxiliar locadoras de livros no gerenciamento de suas operações. O sistema permite o controle eficiente de livros, empréstimos e devoluções,oferecendo uma interface gráfica moderna e responsiva, adaptada para diferentes tamanhos de tela.

### Funcionalidades
 * Gerenciar livros: registrar, atualizar e remover
 * Empréstimo de livros: realizar empréstimo, visualizar empréstimos em andamento, marcar a devolução 
 * Cadastrar dados dos clientes
 * Realizar impressão do documento com informações após realizar o empréstimo

### Regras e validações
 * Não é permitido atualizar a quantidade de livros para uma quantidade menor do que há empréstimos em andamento do mesmo
 * Não é possível alugar livros sem quantidade disponível
 * Não é possível alugar livros sem um cliente atrelado
 * Não é possível remover um livro que possui empréstimos em andamento
 * Atualização de estoque automático conforme os livros são emprestados e devolvidos

### Segurança
 * Ao realizar o primeiro acesso ao aplicativo, o usuário registra suas credenciais que são salvas em arquivo criptografado (AES)
 * Hash de senha do usuário com algoritimo SHA 256

### Estrutura do projeto
        
        ├── LibraryApp/
        │   └── LibraryApp.csproj
        │
        ├── SecurityLibrary/
        │   └── SecurityLibrary.csproj
        │
        └── LibraryApp.sln

### Tecnologias
 * .NET C#
 * WinForms
 * EF Core
 * MySQL

![image](https://github.com/user-attachments/assets/e8d04fd5-9ef1-436e-9b86-a5d73511bf2a)



