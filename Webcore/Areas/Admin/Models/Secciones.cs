﻿// <copyright file="Secciones.cs" company="Dasigno">
//     Copyright (c) 2013 All Rights Reserved
// </copyright>
// <author>Jimmy Rodriguez</author>
namespace Webcore.Areas.Admin.Models
{
    using System.Collections.Generic;
    using Business.Services;
    using Domain.Entities;

    /// <summary>
    /// management the section information
    /// </summary>
    public class Secciones : IAdmin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secciones"/> class
        /// </summary>
        public Secciones()
        {
        }

        /// <summary>
        /// Gets or sets a list of sections
        /// </summary>
        public IEnumerable<Section> CollSections { get; set; }

        /// <summary>
        /// Gets or sets a list of available templates
        /// </summary>
        public IEnumerable<string> CollTemplates { get; set; }

        /// <summary>
        /// Gets or sets a list of available templates
        /// </summary>
        public IEnumerable<string> CollLayouts { get; set; }

        /// <summary>
        /// Gets or sets the information module
        /// </summary>
        public Modul Module { get; set; }

        /// <summary>
        /// Gets or sets the list of modules
        /// </summary>
        public IEnumerable<Modul> ColModul { get; set; }

        /// <summary>
        /// Gets or sets a user application
        /// </summary>
        public CustomPrincipal UserPrincipal { get; set; }

        /// <summary>
        /// Gets or sets the language application
        /// </summary>
        public Language CurrentLanguage { get; set; }
    }
}