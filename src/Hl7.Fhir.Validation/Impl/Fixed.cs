﻿/* 
 * Copyright (c) 2019, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.ElementModel.Functions;
using Hl7.Fhir.Validation.Schema;
using Newtonsoft.Json.Linq;

namespace Hl7.Fhir.Validation.Impl
{
    public class Fixed : SimpleAssertion
    {
        private readonly ITypedElement _fixed;

        public Fixed(ITypedElement fixedValue)
        {
            this._fixed = fixedValue;
        }

        public Fixed(object fixedValue) : this(ElementNode.ForPrimitive(fixedValue)) { }

        protected override string Key => "fixed[x]";

        protected override object Value => _fixed;

        public override Assertions Validate(ITypedElement input, ValidationContext vc)
        {
            if (!EqualityOperators.IsEqualTo(_fixed, input))
            {
                return new Assertions(Assertions.Failure + new TraceText($"Value is not exactly equal to fixed value '{_fixed.Value}'"));
            }

            return Assertions.Success;
        }

        public override JToken ToJson()
        {
            return new JProperty(Key, _fixed.Value);
        }
    }
}
