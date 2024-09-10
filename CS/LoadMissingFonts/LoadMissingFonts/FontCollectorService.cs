using System.Text.Json;

namespace LoadMissingFonts {
    public class FontCollectorService {
        class MyFont {
            public string? Family { get; set; }
            public string? Menu { get; set; }
            public Files? Files { get; set; }
        }

        class MyFontList {
            public List<MyFont>? Items { get; set; }
        }

        class Files {
            public string? regular { get; set; }
        }

        string apiKey = "AIzaSyCv4qcNraSIRkPTvHcQ2jsxKyfAOKZ_aBA";
        string fontApiUrl = "https://www.googleapis.com/webfonts/v1/webfonts/?family=";

        async Task<byte[]?> LoadFontFromGoogle(string fontName) {
            string fontUrl = $"{fontApiUrl}{fontName}&key={apiKey}";
            using (HttpClient client = new HttpClient()) {

                HttpResponseMessage response = await client.GetAsync(fontUrl).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode) {
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
                string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                MyFontList? webfontList = JsonSerializer.Deserialize<MyFontList>(content,new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return await LoadFontFile(webfontList.Items[0].Files.regular).ConfigureAwait(false);
            }

        }
        async Task<byte[]?> LoadFontFile(string fontUrl) {
            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage response = await client.GetAsync(fontUrl).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode) {
                    Console.WriteLine(response.StatusCode);
                    return null;
                }
                using (MemoryStream fileStream = new MemoryStream()) {
                    await response.Content.CopyToAsync(fileStream).ConfigureAwait(false);
                    return fileStream.ToArray();
                }
            }
        }

        public Task<byte[]?> ProcessFont(string fontName) {
            return LoadFontFromGoogle(fontName);
        }
    }
}
