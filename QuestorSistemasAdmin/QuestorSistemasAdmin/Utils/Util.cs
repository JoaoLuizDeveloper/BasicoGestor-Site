using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestorSistemasAdmin.Utils
{
    public class Util
    {
        //public static ArquivoUpload2 ProcessUploadOne(HttpPostedFileBase file, string dirName, string cidadeId, string applicationPath, bool redim, int redimWidth = 800, int redimHeight = 800, string[] acceptedExtensions = null, bool redimensionar = true, string ext = null)
        //{
        //    if (file == null)
        //    {
        //        return new ArquivoUpload2();
        //    }

        //    //request.Files.CopyTo(files, 0);
        //    return UploadOne(file, dirName, cidadeId, applicationPath, redim, redimWidth, redimHeight, acceptedExtensions, ext: ext);
        //}

        //private static ArquivoUpload2 UploadOne(HttpPostedFileBase file, string dirName, string cidadeId, string applicationPath, bool redim, int redimWidth, int redimHeight, string[] acceptedExtensions = null, long? Id = null, CropModel crop = null, string ext = null)
        //{
        //    string dir = "";

        //    if (cidadeId != null)
        //    {
        //        dir = Path.Combine(applicationPath, "conteudo", "clientes", cidadeId, dirName);
        //    }
        //    else
        //    {
        //        dir = Path.Combine(applicationPath, "conteudo", dirName);
        //    }

        //    if (!Directory.Exists(dir))
        //    {
        //        Directory.CreateDirectory(dir);
        //    }

        //    if (file == null)
        //    {
        //        return new ArquivoUpload2();
        //    }

        //    //se for mais que 3.1mb
        //    if (file.ContentLength > 3100000)
        //    {
        //        throw new Exception("O arquivo enviado excedeu o tamanho máximo de 3MB!");
        //    }


        //    var fullFileName = file.FileName;

        //    if (fullFileName.Length > 100)
        //    {
        //        throw new Exception("O arquivo enviado contém um nome muito grande!");
        //    }

        //    var filename = Path.GetFileNameWithoutExtension(fullFileName);
        //    if (string.IsNullOrEmpty(filename))
        //    {
        //        return new ArquivoUpload2();
        //    }

        //    var extension = !string.IsNullOrEmpty(ext) ? ext : Path.GetExtension(file.FileName.ToLower());

        //    if (acceptedExtensions != null)
        //    {
        //        if (!acceptedExtensions.Contains(extension))
        //        {
        //            throw new Exception(string.Format("O arquivo {0} enviado não possui o formato correto. Somente arquivos {1}!", fullFileName, string.Join(", ", acceptedExtensions)));
        //        }
        //    }

        //    var j = 0;
        //    filename = Guid.NewGuid().ToString("n").ToUpper();
        //    var finalName = Id.HasValue ? Id.Value + (redim ? "_original" : "") + extension : filename + (redim ? "_original" : "") + extension;


        //    var finalFullPath = Path.Combine(dir, finalName);
        //    while (File.Exists(finalFullPath))
        //    {
        //        j++;
        //        finalName = filename + "_" + j + (redim ? "_original" : "") + extension;
        //        finalFullPath = Path.Combine(dir, finalName);
        //    }

        //    file.SaveAs(finalFullPath);

        //    if (!redim)
        //    {
        //        return new ArquivoUpload2 { Arquivo = finalName, PostedFile = file };
        //    }

        //    var size = new Size(redimWidth, redimHeight);
        //    var redimSavePath = finalFullPath.Replace("_original.", ".");

        //    using (var imageFactory = new ImageFactory(true))
        //    {
        //        if (crop != null && crop.wI > 0 && crop.hI > 0 && crop.w > 0 && crop.h > 0)
        //        {
        //            imageFactory.Load(finalFullPath)
        //                .Quality(100)
        //                .Crop(new Rectangle(crop.x, crop.y, crop.w, crop.h))
        //                .Resize(new ResizeLayer(size, ResizeMode.Min, AnchorPosition.Center, false, maxSize: size))
        //                .Save(redimSavePath);
        //        }
        //        else
        //        {
        //            imageFactory.Load(finalFullPath)
        //               .Quality(100)
        //               .Resize(new ResizeLayer(size, ResizeMode.Min, AnchorPosition.Center, false, maxSize: size))
        //               .Save(redimSavePath);
        //        }

        //    }

        //    File.Delete(finalFullPath);

        //    return new ArquivoUpload2 { Arquivo = Path.GetFileName(redimSavePath), PostedFile = file };


        //}
    }
}
