namespace Service;

public class OcrService
{
    public string ExtractText(string path)
    {
        using var engine = new TesseractEngine("../tessData", "eng", EngineMode.default);
        
        using var image = Pix.LoadFromFile(path);
        
        using var page = engine.Process(image);

        return page.GetText();
    }
}