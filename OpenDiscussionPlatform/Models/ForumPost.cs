﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenDiscussionPlatform.Models
{
    public class ForumPost
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titlul este obligatoriu")]
        [StringLength(100, ErrorMessage = "Titlul nu poate avea mai mult de 100 caractere")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Continutul postarii este obligatoriu")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Categoria este obligatorie")]
        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

        public IEnumerable<SelectListItem> Categ { get; set; }
    }
}