using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ImplementationClasses;

namespace WebDocs.Models
{
    public class WebDoc : ImplementationClasses.ImplementationActorProp
    {
        /*
         * Followin the API url:
         * https://localhost:44391/api/Documents - see: architecture project
         * read the returned properties.
         * Some opac required for the json response/request and the view
         */

        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document ID")]
        [JsonProperty("ActorPropID")]
        public Guid WebDocID { get => base.ActorPropID; set => base.ActorPropID = value; }

        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document Owner ID")]
        [JsonProperty("ActorID")]
        public Guid WebDocOwnerID { get => base.ActorID; set => base.ActorID = value; }

        [DisplayName("Document Title")]
        [StringLength(250, MinimumLength = 3)]
        [Required(ErrorMessage = "Can't be empty or less than 3 characters")]
        [JsonProperty("ActorPropTitle")]
        public string WebDocTitle { get => base.ActorPropTitle; set => base.ActorPropTitle = value; }

        [ReadOnly(true)]
        [UIHint("readonly")]
        [DisplayName("Document Number")]
        [JsonProperty("Number")]
        public string WebDocNumber { get; set; }
    }
}