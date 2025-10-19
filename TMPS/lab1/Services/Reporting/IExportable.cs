namespace LabSolid.Services.Reporting;

public interface IExportable
{
    void ExportToFile(string filePath);
}