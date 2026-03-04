using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechamentoCaixa.Service
{
    public class BackupService
    {
        public BackupService() { }
        public bool CriarBackup()
        {
            try
            {
                string pastaAtual = AppDomain.CurrentDomain.BaseDirectory;
                string caminhoBanco = Path.Combine(pastaAtual, "fechamento.db");

                if (!File.Exists(caminhoBanco))
                    return false;

                string pastaFechamentos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Fechamentos Finais");
                string pastaBackup = Path.Combine(pastaFechamentos, "Backups");


                if (!Directory.Exists(pastaBackup))
                    Directory.CreateDirectory(pastaBackup);

                string nomeBackup = $"fechamento_backup_{DateOnly.FromDateTime(DateTime.Now)}.db";
                if (File.Exists(nomeBackup))
                    Console.WriteLine("Backup ja existente!");
                    return true;
                string caminhoBackup = Path.Combine(pastaBackup, nomeBackup);

                File.Copy(caminhoBanco, caminhoBackup);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao gerar backup: " + ex.Message);
                return false;
            }
        }
    }
}
