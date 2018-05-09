﻿using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace Quizer.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class QuestionViewModel
    {
        public QuestionViewModel()
        {
        }

        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Text { get; set; }

        public string Notes { get; set; }
        [DefaultValue(0)]
        public int Type { get; set; }
        [DefaultValue(0)]
        public int Flags { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
