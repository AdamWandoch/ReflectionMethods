# ReflectionMethods

### Exemplo como resolver complexidade da validacao da funcionalidade das telas

Implementando ValidarAcesso() no BasePage, usando o enum do mapeamento do nomes das classes das telas que erdem do BasePage podemos executar a validacao do qualquer classe sem chamar nenhuma metoda. O construtor sem parametros do BasePage esta sendo sempre executado para classes derivadas antes de fazer qualquer outra coisa, tmb pra aqueles que tem override dele.

[!Image](img/screen1.jpg)
[!Image](img/screen2.jpg)
[!Image](img/screen3.jpg)