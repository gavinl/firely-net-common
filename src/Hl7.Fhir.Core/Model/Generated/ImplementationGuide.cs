﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Tue, Aug 18, 2015 10:39+0200 for FHIR v0.5.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A set of rules about how FHIR is used
    /// </summary>
    [FhirType("ImplementationGuide", IsResource=true)]
    [DataContract]
    public partial class ImplementationGuide : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImplementationGuide; } }
        [NotMapped]
        public override string TypeName { get { return "ImplementationGuide"; } }
        
        /// <summary>
        /// How a dependency is represented when the guide is published
        /// </summary>
        [FhirEnumeration("GuideDependencyType")]
        public enum GuideDependencyType
        {
            /// <summary>
            /// The guide is referred to by URL
            /// </summary>
            [EnumLiteral("reference")]
            Reference,
            /// <summary>
            /// The guide is embedded in this guide when published
            /// </summary>
            [EnumLiteral("inclusion")]
            Inclusion,
        }
        
        /// <summary>
        /// Why a resource is included in the guide
        /// </summary>
        [FhirEnumeration("GuideResourcePurpose")]
        public enum GuideResourcePurpose
        {
            /// <summary>
            /// The resource is intended as an example
            /// </summary>
            [EnumLiteral("example")]
            Example,
            /// <summary>
            /// The resource defines a value set or concept map used in the Implementation Guide
            /// </summary>
            [EnumLiteral("terminology")]
            Terminology,
            /// <summary>
            /// The resource defines a profile (StructureDefinition) that is used in the implementation guide
            /// </summary>
            [EnumLiteral("profile")]
            Profile,
            /// <summary>
            /// The resource defines an extension (StructureDefinition) that is used in the implementation guide
            /// </summary>
            [EnumLiteral("extension")]
            Extension,
            /// <summary>
            /// The resource contains a dictionary that is part of the implementation guide
            /// </summary>
            [EnumLiteral("dictionary")]
            Dictionary,
            /// <summary>
            /// The resource defines a logical model (in a StructureDefinition) that is used in the implementation guide
            /// </summary>
            [EnumLiteral("logical")]
            Logical,
        }
        
        /// <summary>
        /// The kind of an included page
        /// </summary>
        [FhirEnumeration("GuidePageKind")]
        public enum GuidePageKind
        {
            /// <summary>
            /// This is a page of content that is included in the implementation guide. It has no particular function
            /// </summary>
            [EnumLiteral("page")]
            Page,
            /// <summary>
            /// This is a page that represents a human readable rendering of an example
            /// </summary>
            [EnumLiteral("example")]
            Example,
            /// <summary>
            /// This is a page that represents a list of resources of one or more types
            /// </summary>
            [EnumLiteral("list")]
            List,
            /// <summary>
            /// This is a page that is where an included guide is injected
            /// </summary>
            [EnumLiteral("include")]
            Include,
            /// <summary>
            /// This is a page that lists the resources of a given type, and also creates pages for all the listed types as other pages in the section
            /// </summary>
            [EnumLiteral("directory")]
            Directory,
            /// <summary>
            /// This is a page that creates the listed resources as a dictionary
            /// </summary>
            [EnumLiteral("dictionary")]
            Dictionary,
            /// <summary>
            /// This is a generated page that contains the table of contents
            /// </summary>
            [EnumLiteral("toc")]
            Toc,
            /// <summary>
            /// This is a page that represents a presented resource. This is typically used for generated conformance resource presentations
            /// </summary>
            [EnumLiteral("resource")]
            Resource,
        }
        
        [FhirType("ImplementationGuideDependencyComponent")]
        [DataContract]
        public partial class ImplementationGuideDependencyComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuideDependencyComponent"; } }
            
            /// <summary>
            /// reference | inclusion
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ImplementationGuide.GuideDependencyType> TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ImplementationGuide.GuideDependencyType> _TypeElement;
            
            /// <summary>
            /// reference | inclusion
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ImplementationGuide.GuideDependencyType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Code<Hl7.Fhir.Model.ImplementationGuide.GuideDependencyType>(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Where to find dependency
            /// </summary>
            [FhirElement("uri", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UriElement
            {
                get { return _UriElement; }
                set { _UriElement = value; OnPropertyChanged("UriElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _UriElement;
            
            /// <summary>
            /// Where to find dependency
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if(value == null)
                      UriElement = null; 
                    else
                      UriElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuideDependencyComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.ImplementationGuide.GuideDependencyType>)TypeElement.DeepCopy();
                    if(UriElement != null) dest.UriElement = (Hl7.Fhir.Model.FhirUri)UriElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuideDependencyComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideDependencyComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideDependencyComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ImplementationGuideGlobalComponent")]
        [DataContract]
        public partial class ImplementationGuideGlobalComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuideGlobalComponent"; } }
            
            /// <summary>
            /// Type this profiles applies to
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.Code _TypeElement;
            
            /// <summary>
            /// Type this profiles applies to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new Hl7.Fhir.Model.Code(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Profile that all resources must conform to
            /// </summary>
            [FhirElement("profile", InSummary=true, Order=50)]
            [References("StructureDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Profile
            {
                get { return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Profile;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuideGlobalComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.Code)TypeElement.DeepCopy();
                    if(Profile != null) dest.Profile = (Hl7.Fhir.Model.ResourceReference)Profile.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuideGlobalComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideGlobalComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideGlobalComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ImplementationGuidePackageResourceComponent")]
        [DataContract]
        public partial class ImplementationGuidePackageResourceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuidePackageResourceComponent"; } }
            
            /// <summary>
            /// example | terminology | profile | extension | dictionary | logical
            /// </summary>
            [FhirElement("purpose", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ImplementationGuide.GuideResourcePurpose> PurposeElement
            {
                get { return _PurposeElement; }
                set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ImplementationGuide.GuideResourcePurpose> _PurposeElement;
            
            /// <summary>
            /// example | terminology | profile | extension | dictionary | logical
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ImplementationGuide.GuideResourcePurpose? Purpose
            {
                get { return PurposeElement != null ? PurposeElement.Value : null; }
                set
                {
                    if(value == null)
                      PurposeElement = null; 
                    else
                      PurposeElement = new Code<Hl7.Fhir.Model.ImplementationGuide.GuideResourcePurpose>(value);
                    OnPropertyChanged("Purpose");
                }
            }
            
            /// <summary>
            /// Human Name for the resource
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Human Name for the resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Reason why included in guide
            /// </summary>
            [FhirElement("description", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Reason why included in guide
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Short code to identify the resource
            /// </summary>
            [FhirElement("acronym", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AcronymElement
            {
                get { return _AcronymElement; }
                set { _AcronymElement = value; OnPropertyChanged("AcronymElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AcronymElement;
            
            /// <summary>
            /// Short code to identify the resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Acronym
            {
                get { return AcronymElement != null ? AcronymElement.Value : null; }
                set
                {
                    if(value == null)
                      AcronymElement = null; 
                    else
                      AcronymElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Acronym");
                }
            }
            
            /// <summary>
            /// Location of the resource
            /// </summary>
            [FhirElement("source", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Source
            {
                get { return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private Hl7.Fhir.Model.Element _Source;
            
            /// <summary>
            /// Resource this is an example of (if applicable)
            /// </summary>
            [FhirElement("exampleFor", InSummary=true, Order=90)]
            [References("StructureDefinition")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference ExampleFor
            {
                get { return _ExampleFor; }
                set { _ExampleFor = value; OnPropertyChanged("ExampleFor"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _ExampleFor;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuidePackageResourceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PurposeElement != null) dest.PurposeElement = (Code<Hl7.Fhir.Model.ImplementationGuide.GuideResourcePurpose>)PurposeElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(AcronymElement != null) dest.AcronymElement = (Hl7.Fhir.Model.FhirString)AcronymElement.DeepCopy();
                    if(Source != null) dest.Source = (Hl7.Fhir.Model.Element)Source.DeepCopy();
                    if(ExampleFor != null) dest.ExampleFor = (Hl7.Fhir.Model.ResourceReference)ExampleFor.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuidePackageResourceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePackageResourceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(AcronymElement, otherT.AcronymElement)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                if( !DeepComparable.Matches(ExampleFor, otherT.ExampleFor)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePackageResourceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(AcronymElement, otherT.AcronymElement)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if( !DeepComparable.IsExactly(ExampleFor, otherT.ExampleFor)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ImplementationGuidePageComponent")]
        [DataContract]
        public partial class ImplementationGuidePageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuidePageComponent"; } }
            
            /// <summary>
            /// Where to find that page
            /// </summary>
            [FhirElement("source", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri SourceElement
            {
                get { return _SourceElement; }
                set { _SourceElement = value; OnPropertyChanged("SourceElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _SourceElement;
            
            /// <summary>
            /// Where to find that page
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if(value == null)
                      SourceElement = null; 
                    else
                      SourceElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Source");
                }
            }
            
            /// <summary>
            /// Short name shown for navigational assistance
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Short name shown for navigational assistance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// page | example | list | include | directory | dictionary | toc | resource
            /// </summary>
            [FhirElement("kind", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageKind> KindElement
            {
                get { return _KindElement; }
                set { _KindElement = value; OnPropertyChanged("KindElement"); }
            }
            
            private Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageKind> _KindElement;
            
            /// <summary>
            /// page | example | list | include | directory | dictionary | toc | resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.ImplementationGuide.GuidePageKind? Kind
            {
                get { return KindElement != null ? KindElement.Value : null; }
                set
                {
                    if(value == null)
                      KindElement = null; 
                    else
                      KindElement = new Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageKind>(value);
                    OnPropertyChanged("Kind");
                }
            }
            
            /// <summary>
            /// Kind of resource to include in the list
            /// </summary>
            [FhirElement("type", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Code> TypeElement
            {
                get { if(_TypeElement==null) _TypeElement = new List<Hl7.Fhir.Model.Code>(); return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private List<Hl7.Fhir.Model.Code> _TypeElement;
            
            /// <summary>
            /// Kind of resource to include in the list
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Type
            {
                get { return TypeElement != null ? TypeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      TypeElement = null; 
                    else
                      TypeElement = new List<Hl7.Fhir.Model.Code>(value.Select(elem=>new Hl7.Fhir.Model.Code(elem)));
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Name of package to include
            /// </summary>
            [FhirElement("package", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> PackageElement
            {
                get { if(_PackageElement==null) _PackageElement = new List<Hl7.Fhir.Model.FhirString>(); return _PackageElement; }
                set { _PackageElement = value; OnPropertyChanged("PackageElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _PackageElement;
            
            /// <summary>
            /// Name of package to include
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Package
            {
                get { return PackageElement != null ? PackageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if(value == null)
                      PackageElement = null; 
                    else
                      PackageElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Package");
                }
            }
            
            /// <summary>
            /// Format of the page (e.g. html, markdown etc)
            /// </summary>
            [FhirElement("format", InSummary=true, Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.Code FormatElement
            {
                get { return _FormatElement; }
                set { _FormatElement = value; OnPropertyChanged("FormatElement"); }
            }
            
            private Hl7.Fhir.Model.Code _FormatElement;
            
            /// <summary>
            /// Format of the page (e.g. html, markdown etc)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Format
            {
                get { return FormatElement != null ? FormatElement.Value : null; }
                set
                {
                    if(value == null)
                      FormatElement = null; 
                    else
                      FormatElement = new Hl7.Fhir.Model.Code(value);
                    OnPropertyChanged("Format");
                }
            }
            
            /// <summary>
            /// Nested Pages / Sections
            /// </summary>
            [FhirElement("page", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent> Page
            {
                get { if(_Page==null) _Page = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent>(); return _Page; }
                set { _Page = value; OnPropertyChanged("Page"); }
            }
            
            private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent> _Page;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuidePageComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SourceElement != null) dest.SourceElement = (Hl7.Fhir.Model.FhirUri)SourceElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(KindElement != null) dest.KindElement = (Code<Hl7.Fhir.Model.ImplementationGuide.GuidePageKind>)KindElement.DeepCopy();
                    if(TypeElement != null) dest.TypeElement = new List<Hl7.Fhir.Model.Code>(TypeElement.DeepCopy());
                    if(PackageElement != null) dest.PackageElement = new List<Hl7.Fhir.Model.FhirString>(PackageElement.DeepCopy());
                    if(FormatElement != null) dest.FormatElement = (Hl7.Fhir.Model.Code)FormatElement.DeepCopy();
                    if(Page != null) dest.Page = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent>(Page.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuidePageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePageComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(PackageElement, otherT.PackageElement)) return false;
                if( !DeepComparable.Matches(FormatElement, otherT.FormatElement)) return false;
                if( !DeepComparable.Matches(Page, otherT.Page)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePageComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(PackageElement, otherT.PackageElement)) return false;
                if( !DeepComparable.IsExactly(FormatElement, otherT.FormatElement)) return false;
                if( !DeepComparable.IsExactly(Page, otherT.Page)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ImplementationGuidePackageComponent")]
        [DataContract]
        public partial class ImplementationGuidePackageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuidePackageComponent"; } }
            
            /// <summary>
            /// Name used .page.package
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name used .page.package
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Human readable text describing the package
            /// </summary>
            [FhirElement("description", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Human readable text describing the package
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if(value == null)
                      DescriptionElement = null; 
                    else
                      DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Resource in the implementation guide
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageResourceComponent> Resource
            {
                get { if(_Resource==null) _Resource = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageResourceComponent>(); return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageResourceComponent> _Resource;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuidePackageComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Resource != null) dest.Resource = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageResourceComponent>(Resource.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuidePackageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePackageComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuidePackageComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ImplementationGuideContactComponent")]
        [DataContract]
        public partial class ImplementationGuideContactComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationGuideContactComponent"; } }
            
            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if(value == null)
                      NameElement = null; 
                    else
                      NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ContactPoint> Telecom
            {
                get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.ContactPoint>(); return _Telecom; }
                set { _Telecom = value; OnPropertyChanged("Telecom"); }
            }
            
            private List<Hl7.Fhir.Model.ContactPoint> _Telecom;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationGuideContactComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ImplementationGuideContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideContactComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationGuideContactComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Literal URL used to reference this Implementation Guide
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Literal URL used to reference this Implementation Guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if(value == null)
                  UrlElement = null; 
                else
                  UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Url");
            }
        }
        
        /// <summary>
        /// Logical id for this version of the Implementation Guide
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Logical id for this version of the Implementation Guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if(value == null)
                  VersionElement = null; 
                else
                  VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// Informal name for this Implementation Guide
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Informal name for this Implementation Guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if(value == null)
                  NameElement = null; 
                else
                  NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ConformanceResourceStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ConformanceResourceStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if(value == null)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if(value == null)
                  ExperimentalElement = null; 
                else
                  ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if(value == null)
                  PublisherElement = null; 
                else
                  PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideContactComponent> _Contact;
        
        /// <summary>
        /// Date for this version of the Implementation Guide
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date for this version of the Implementation Guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if(value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Natural language description of the Implementation Guide
        /// </summary>
        [FhirElement("description", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the Implementation Guide
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// The implementation guide is intended to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _UseContext;
        
        /// <summary>
        /// Use and/or Publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CopyrightElement
        {
            get { return _CopyrightElement; }
            set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CopyrightElement;
        
        /// <summary>
        /// Use and/or Publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if(value == null)
                  CopyrightElement = null; 
                else
                  CopyrightElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }
        
        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=true, Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Id FhirVersionElement
        {
            get { return _FhirVersionElement; }
            set { _FhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }
        
        private Hl7.Fhir.Model.Id _FhirVersionElement;
        
        /// <summary>
        /// FHIR Version this Implementation Guide targets
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if(value == null)
                  FhirVersionElement = null; 
                else
                  FhirVersionElement = new Hl7.Fhir.Model.Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }
        
        /// <summary>
        /// Another Implementation guide this depends on
        /// </summary>
        [FhirElement("dependency", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideDependencyComponent> Dependency
        {
            get { if(_Dependency==null) _Dependency = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideDependencyComponent>(); return _Dependency; }
            set { _Dependency = value; OnPropertyChanged("Dependency"); }
        }
        
        private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideDependencyComponent> _Dependency;
        
        /// <summary>
        /// Group of resources as used in .page.package
        /// </summary>
        [FhirElement("package", InSummary=true, Order=220)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageComponent> Package
        {
            get { if(_Package==null) _Package = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageComponent>(); return _Package; }
            set { _Package = value; OnPropertyChanged("Package"); }
        }
        
        private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageComponent> _Package;
        
        /// <summary>
        /// Profiles that apply globally
        /// </summary>
        [FhirElement("global", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideGlobalComponent> Global
        {
            get { if(_Global==null) _Global = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideGlobalComponent>(); return _Global; }
            set { _Global = value; OnPropertyChanged("Global"); }
        }
        
        private List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideGlobalComponent> _Global;
        
        /// <summary>
        /// Image, css, script, etc
        /// </summary>
        [FhirElement("binary", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirUri> BinaryElement
        {
            get { if(_BinaryElement==null) _BinaryElement = new List<Hl7.Fhir.Model.FhirUri>(); return _BinaryElement; }
            set { _BinaryElement = value; OnPropertyChanged("BinaryElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirUri> _BinaryElement;
        
        /// <summary>
        /// Image, css, script, etc
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Binary
        {
            get { return BinaryElement != null ? BinaryElement.Select(elem => elem.Value) : null; }
            set
            {
                if(value == null)
                  BinaryElement = null; 
                else
                  BinaryElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                OnPropertyChanged("Binary");
            }
        }
        
        /// <summary>
        /// Page/Section in the Guide
        /// </summary>
        [FhirElement("page", InSummary=true, Order=250)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent Page
        {
            get { return _Page; }
            set { _Page = value; OnPropertyChanged("Page"); }
        }
        
        private Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent _Page;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImplementationGuide;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ConformanceResourceStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideContactComponent>(Contact.DeepCopy());
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.CodeableConcept>(UseContext.DeepCopy());
                if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.FhirString)CopyrightElement.DeepCopy();
                if(FhirVersionElement != null) dest.FhirVersionElement = (Hl7.Fhir.Model.Id)FhirVersionElement.DeepCopy();
                if(Dependency != null) dest.Dependency = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideDependencyComponent>(Dependency.DeepCopy());
                if(Package != null) dest.Package = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePackageComponent>(Package.DeepCopy());
                if(Global != null) dest.Global = new List<Hl7.Fhir.Model.ImplementationGuide.ImplementationGuideGlobalComponent>(Global.DeepCopy());
                if(BinaryElement != null) dest.BinaryElement = new List<Hl7.Fhir.Model.FhirUri>(BinaryElement.DeepCopy());
                if(Page != null) dest.Page = (Hl7.Fhir.Model.ImplementationGuide.ImplementationGuidePageComponent)Page.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ImplementationGuide());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.Matches(Dependency, otherT.Dependency)) return false;
            if( !DeepComparable.Matches(Package, otherT.Package)) return false;
            if( !DeepComparable.Matches(Global, otherT.Global)) return false;
            if( !DeepComparable.Matches(BinaryElement, otherT.BinaryElement)) return false;
            if( !DeepComparable.Matches(Page, otherT.Page)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImplementationGuide;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.IsExactly(Dependency, otherT.Dependency)) return false;
            if( !DeepComparable.IsExactly(Package, otherT.Package)) return false;
            if( !DeepComparable.IsExactly(Global, otherT.Global)) return false;
            if( !DeepComparable.IsExactly(BinaryElement, otherT.BinaryElement)) return false;
            if( !DeepComparable.IsExactly(Page, otherT.Page)) return false;
            
            return true;
        }
        
    }
    
}