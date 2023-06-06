# prototipacao_mobile_csharp
Prototipação de app com windows forms usando csharp.

## Projeto para modelagem de app via MS Windows Forms com CSharp (projeto recomendado para Devs que não queiram prototipar usando o Xamarin).

Objetivos: Permitir que programadores possam realizar um rápida prototipação de uma aplicação mobile, usando a linguagem CSharp via Windows Forms, caso não desejem ou possam utilizar o Xamarin forms ou outra tecnologia (como o Monodevelop e/ou Sharpdevelop).

Atenção: O projeto pronto é apenas um "boneco" (protótipo) para que se possam discutir idéias de uma futura app mobile, este código (.EXE) para Windows (não roda em um cel Android/IOS).

Detalhes: Este exemplo realiza chamadas simples simples entre formulários Windows Forms na linguagem C# (C Sharp). Em uma dos formulários (FormOpcaoA) são utilizados os controles Material. E no formulário FormB1 existe um componente webview que carrega uma URL (no exemplo foi carregada a wikipedia). Existem também alguns exemplos do uso de MessageBox em vários botões do projeto. O login é fictício pois o objetivo do projeto é apenas a navegação entre telas.

Descrição de arquivos:
1. Diagrama_v1.pdf contém um arquivo PDF com um esquema hierarquico de navegação entre as telas.
2. Diagrama_v1.png é identico ao PDF, no formato PNG (para ser utilizado na página principal do projeto).
3. refman.pdf arquivo gerado pelo Doxygen via Doxywizard, é a documentação automática do projeto. A documentação gerada automaticamente pelo doxygen esta na url: https://www.messier83.com.br/prototipacao_mobile_csharp/documentacao/index.html
4. A imagem imagem_fundo_cel.jpg é uma figura utilizada como fundo dos formulários, a fonte da figura é: 
https://pixabay.com/pt/vectors/andr%c3%b3ide-nexus-5-telefone-1294370/, os créditos desta figura são de: OpenClipart-Vectors. A imagem imagem_fundo_cel.png esta localizado no projeto em WindowsFormsApp2/Properties
/imagens/ sob o nome de android1.png
5. Foi utilizado o MaterialSkin versão 0.2.2 baixado via NuGet, existe uma atualização aqui: https://www.nuget.org/packages/MaterialSkin.2/
6. WindowsFormsSimulacaoAppMobile_v1.zip contém o arquivo de solução e códigos fontes em Csharp para ser aberto no Visual Studio.

Licença Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0) : [cc-by-nc-sa-image]: https://creativecommons.org/licenses/by-nc-sa/4.0/


#### Diferenças entre Wireframe x Mockup x Prototipação

| Wireframe  | Mockup | Prototipo |
| ------------- | ------------- | ------- |
| Mostra estrutura de blocos, pode ser considerado um esqueleto do projeto | Apresenta cores, estipo visual e tipografia de fontes | Mais perto da versão final |
| Desenho de interface básico  | Testes de responsividade, tem conteúdo estático | Permite simular interação com o usuário, pois pode conter dados |
| Barato  | Melhorar usuário dar um feedback | Pode ter partes clicáveis e mostrar dados fictícios |
| Criado em curto espaço de tempo | Pode levar mais tempo para ficar pronto | Demorar mais tempo devido a complexidade de interações dentro do protótipo |
| Pode ser uma desenho no papel, representação de baixa qualidade e fidelidade  | Apresenta especto visual perto do final | Poderá ser reaproveitado |
| $  | $$ | $$$ |
| Exemplos de softwares: Balsamiq, Adobe XD, Evolus, UXpin  | Exemplos de software: InVision, Moqups, Photoshop, Evolus | Exemplos de softwares: FlutterFlow, Mockplus, Adobe XD, Android Studio, Embarcadero Delphi, MS Xamarin |

Fonte:

[1] https://tecnoblog.net/responde/qual-e-a-diferenca-entre-wireframe-mockup-e-prototipo/

[2] https://www.vitaminaweb.com.br/wireframe-prototipo-e-mockup-qual-a-diferenca/

[3] https://webflow.com/blog/always-choose-prototypes-over-mockups?utm_source=google&utm_medium=search&utm_campaign=Google-Search-Dynamic-Search-Ads-Global-BBSS&utm_term=dsa-1480385100845___617245336972___ss_paid-bb&gclid=EAIaIQobChMI-K_Vyqer_wIVk0FIAB3ymAMbEAAYASAAEgKRd_D_BwE


Visualização do projeto:

![alt text](https://github.com/monteiro74/prototipacao_mobile_csharp/blob/main/Diagrama_v1.png)

