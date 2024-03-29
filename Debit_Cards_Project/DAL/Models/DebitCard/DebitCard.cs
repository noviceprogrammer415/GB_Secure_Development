﻿using System.Text.Json.Serialization;

namespace Debit_Cards_Project.DAL.Models.DebitCard
{
    public sealed class DebitCard
    {
        /// <summary> Название валюты </summary>
        public string CurrencyName { get; set; }

        [JsonIgnore]
        public int HolderId { get; set; }

        /// <summary> Держатель карты </summary>
        public Holder Holder { get; set; }

        [JsonIgnore]
        public int Id { get; set; }

        /// <summary> Номер карты </summary>
        public long NumberCard { get; set; }

        /// <summary> Месяц действия </summary>
        public int Month { get; set; }

        /// <summary> Год действия  </summary>
        public int Year { get; set; }
    }
}
