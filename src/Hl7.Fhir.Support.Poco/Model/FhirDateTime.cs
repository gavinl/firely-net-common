﻿/*
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

using System;
using Hl7.Fhir.Serialization;

namespace Hl7.Fhir.Model
{
    public partial class FhirDateTime
    {
        public const string FMT_FULL = "yyyy-MM-dd'T'HH:mm:ssK";
        public const string FMT_YEAR = "{0:D4}";
        public const string FMT_YEARMONTH = "{0:D4}-{1:D2}";
        public const string FMT_YEARMONTHDAY = "{0:D4}-{1:D2}-{2:D2}";

        public FhirDateTime(DateTimeOffset dt) : this(PrimitiveTypeConverter.ConvertTo<string>(dt))
        {
        }

        [Obsolete("Use FhirDateTime(DateTimeOffset dt) instead")]
        public FhirDateTime(DateTime dt) : this(new DateTimeOffset(dt))
        {
        }

        [Obsolete("Use FhirDateTime(int year, int month, int day, int hr, int min, int sec, TimeSpan offset) instead")]
        public FhirDateTime(int year, int month, int day, int hr, int min, int sec = 0)
            : this(new DateTime(year, month, day, hr, min, sec, DateTimeKind.Local))
        {
        }

        public FhirDateTime(int year, int month, int day, int hr, int min, int sec, TimeSpan offset)
            : this(new DateTimeOffset(year, month, day, hr, min, sec, offset))
        {
        }


        public FhirDateTime(int year, int month, int day)
            : this(string.Format(System.Globalization.CultureInfo.InvariantCulture, FMT_YEARMONTHDAY, year, month, day))
        {
        }

        public FhirDateTime(int year, int month)
            : this(string.Format(System.Globalization.CultureInfo.InvariantCulture, FMT_YEARMONTH, year, month))
        {
        }

        public FhirDateTime(int year)
            : this(string.Format(System.Globalization.CultureInfo.InvariantCulture, FMT_YEAR, year))
        {
        }

        public static FhirDateTime Now()
        {
            return new FhirDateTime(PrimitiveTypeConverter.ConvertTo<string>(DateTimeOffset.Now));
        }

        [Obsolete("Use ToDateTimeOffset(TimeSpan zone) instead. Obsolete since 2018-11-22")]
        public DateTimeOffset ToDateTimeOffset(TimeSpan? zone = null) =>
            ToDateTimeOffset(zone ?? TimeSpan.Zero);

        /// <summary>
        /// Converts this Fhir DateTime as a .NET DateTimeOffset
        /// </summary>
        /// <param name="zone">Ensures the returned DateTimeOffset uses the the specified zone.</param>
        /// <remarks>In .NET the minimal value for DateTimeOffset is 1/1/0001 12:00:00 AM +00:00. That means,for example, 
        /// a FhirDateTime of "0001-01-01T00:00:00+01:00" could not be converted to a DateTimeOffset. In that case a 
        /// ArgumentOutOfRangeException will be thrown.</remarks>
        /// <returns>A DateTimeOffset filled out to midnight, january 1 (UTC) in case of a partial date/time. If the Fhir DateTime
        /// does not specify a timezone, the UTC (Coordinated Universal Time) is assumed. Note that the zone parameter has no 
        /// effect on this, this merely converts the given Fhir datetime to the desired timezone</returns>
        public DateTimeOffset ToDateTimeOffset(TimeSpan zone)
        {
            if (this.Value == null) throw new InvalidOperationException("FhirDateTime's value is null");

            // ToDateTimeOffset() will convert partial date/times by filling out to midnight/january 1 UTC
            // When there's no timezone, the UTC is assumed
            var dto = PrimitiveTypeConverter.ConvertTo<DateTimeOffset>(this.Value);

            return dto.ToOffset(zone);
        }


        [Obsolete("Use ToDateTimeOffset(TimeSpan zone) instead")]
        public DateTime? ToDateTime() 
            => Value == null ? null : (DateTime?)PrimitiveTypeConverter.ConvertTo<DateTime>(Value);
    }

}
