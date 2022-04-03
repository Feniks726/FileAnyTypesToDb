using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileAnyTypesToDb.Domain.Models
{
    public class FileData
    {
        /// <summary>
        /// Возвращает или задаёт идентификатор файла.
        /// </summary>
        /// <value>
        /// Идентификатор файла.
        /// </value>
        [Column(Order = 0)]
        public Guid Id { get; set; }

        /// <summary>
        /// Возвращает имя файла.
        /// </summary>
        /// <value>
        /// Имя файла.
        /// </value>
        [Column(Order = 1)]
        public string FileName { get; set; }

        /// <summary>
        /// Возвращает содержимое файла.
        /// </summary>
        /// <value>
        /// Содержимое файла.
        /// </value>
        [Column(Order = 2)]
        public byte[] Content { get; set; }
    }
}
