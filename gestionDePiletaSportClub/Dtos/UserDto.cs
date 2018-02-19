﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using gestionDePiletaSportClub.Models;

namespace gestionDePiletaSportClub.Dtos
{
    public class UserDto
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "DNI")]
        public int DNI { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public Nullable<DateTime> BirthDay { get; set; }

        public LevelDto Level { get; set; }


        [Display(Name = "Nivel")]
        public byte? LevelId { get; set; }

        public PaymentTypeDto PaymentType { get; set; }


        [Display(Name = "Tipo de pago")]
        public byte? PaymentTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime LastPaymentDate { get; set; }

        public DateTime DueDate { get; set; }

        public byte AmountOfActivities { get; set; }


        [Display(Name = "Plan")]
        public byte? MembershipTypeId { get; set; }


        [Required]
        [Display(Name = "EMAIL")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

    }
}