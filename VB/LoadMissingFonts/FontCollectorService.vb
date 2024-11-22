Imports System.Net.Http
Imports System.Text.Json

Namespace LoadMissingFonts

    Public Class FontCollectorService

        Private Class MyFont

            Public Property Family As String?

            Public Property Menu As String?

            Public Property Files As Files?
        End Class

        Private Class MyFontList

            Public Property Items As List(Of MyFont)?
        End Class

        Private Class Files

            Public Property regular As String?
        End Class

        Private apiKey As String = "YOUR_API_KEY"

        Private fontApiUrl As String = "https://www.googleapis.com/webfonts/v1/webfonts/?family="

         ''' Cannot convert MethodDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         async Task<byte[]?> LoadFontFromGoogle(string fontName) {
'''             string fontUrl = $"{this.fontApiUrl}{fontName}&key={this.apiKey}";
'''             using (HttpClient client = new HttpClient()) {
''' 
'''                 HttpResponseMessage response = await client.GetAsync(fontUrl).ConfigureAwait(false);
'''                 if (!response.IsSuccessStatusCode) {
'''                     Console.WriteLine(response.StatusCode);
'''                     return null;
'''                 }
'''                 string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
'''                 LoadMissingFonts.FontCollectorService.MyFontList? webfontList = JsonSerializer.Deserialize<LoadMissingFonts.FontCollectorService.MyFontList>(content,new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
'''                 return await LoadFontFile(webfontList.Items[0].Files.regular).ConfigureAwait(false);
'''             }
''' 
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         async Task<byte[]?> LoadFontFile(string fontUrl) {
'''             using (HttpClient client = new HttpClient()) {
'''                 HttpResponseMessage response = await client.GetAsync(fontUrl).ConfigureAwait(false);
'''                 if (!response.IsSuccessStatusCode) {
'''                     Console.WriteLine(response.StatusCode);
'''                     return null;
'''                 }
'''                 using (MemoryStream fileStream = new MemoryStream()) {
'''                     await response.Content.CopyToAsync(fileStream).ConfigureAwait(false);
'''                     return fileStream.ToArray();
'''                 }
'''             }
'''         }
''' 
'''   ''' Cannot convert MethodDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.TypeSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
'''         public Task<byte[]?> ProcessFont(string fontName) {
'''             return this.LoadFontFromGoogle(fontName);
'''         }
''' 
'''  End Class
End Namespace
