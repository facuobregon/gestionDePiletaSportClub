﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using gestionDePiletaSportClub.Models;

namespace gestionDePiletaSportClub.Models
{
    public class Actividad
    {
        [Required]
        public int Id { get; set; }

        
        [Required]
        [Display(Name ="Nivel")]
        public byte LevelId { get; set; }

        public Level Level { get; set; }


        [Required]
        [Display(Name = "Plan")]
        public byte MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; }



        [Required]
        [Display(Name = "Tipo de Actividad")]
        public byte TipoActividadId { get; set; }

        public TipoActividad TipoActividad { get; set; }

        [Display(Name = "Cantidad maxima de alumnos")]
        public byte AmountOfEnrollment { get; set; }

        [Display(Name = "Inscripciones pendientes")]
        public byte PendingEnrollment { get; set; }

        [Required]
        [Display(Name = "Horario")]
        //public DateTime Schedule { get; set; }
        public string Schedule { get; set; }

        [Required]
        [Display(Name ="Estado")]
        public byte EstadoActividadId { get; set; }

        public EstadoActividad EstadoActividad { get; set; }

        public int? MasterActivityId { get; set; }
        public MasterActivity MasterActivity { get; set; }

        [Required]
        [Display(Name = "Duracion")]
        public int Duration { get; set; }

    }
}