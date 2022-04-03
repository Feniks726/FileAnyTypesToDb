using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FileAnyTypesToDb.Domain.Models
{
    public class FileExtentions
    {

        /// <summary>
        /// Возвращает или задаёт идентификатор расширения файла.
        /// </summary>
        /// <value>
        /// Идентификатор расширения файла.
        /// </value>
        [Column(Order = 0)]
        public Guid Id { get; set; }

        /// <summary>
        /// Возвращает расширения файла.
        /// </summary>
        /// <value>
        /// Расширение файла.
        /// </value>
        [Column(Order = 1)]
        public string Name { get; set; }
    }
}
