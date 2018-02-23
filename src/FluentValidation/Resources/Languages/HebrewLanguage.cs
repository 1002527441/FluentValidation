#region License
// Copyright (c) Jeremy Skinner (http://www.jeremyskinner.co.uk)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// The latest version of this file can be found at https://github.com/JeremySkinner/FluentValidation
#endregion

namespace FluentValidation.Resources {
	using Validators;

	internal class HebrewLanguage : Language {
		public override string Name => "he";

		public HebrewLanguage() {
			Translate<EmailValidator>("'{PropertyName}' ���� ����� ���\"� �����.");
			Translate<GreaterThanOrEqualValidator>("'{PropertyName}' ���� ����� ���� �� ���� �- '{ComparisonValue}'.");
			Translate<GreaterThanValidator>("'{PropertyName}' ���� ����� ���� �- '{ComparisonValue}'.");
			Translate<LengthValidator>("���� '{PropertyName}' ���� ����� ��� {MinLength} �- {MaxLength}. ���� {TotalLength} �����.");
			Translate<MinimumLengthValidator>("���� '{PropertyName}' ���� ����� ����� {MinLength} �����. ���� {TotalLength} �����.");
			Translate<MaximumLengthValidator>("���� '{PropertyName}' ���� ����� {MaxLength} ����� �� ����. ���� {TotalLength} �����.");
			Translate<LessThanOrEqualValidator>("'{PropertyName}' ���� ����� ��� �� ���� �- '{ComparisonValue}'.");
			Translate<LessThanValidator>("'{PropertyName}' ���� ����� ��� �- '{ComparisonValue}'.");
			Translate<NotEmptyValidator>("'{PropertyName}' �� ���� ����� ���.");
			Translate<NotEqualValidator>("'{PropertyName}' �� ���� ����� ���� �- '{ComparisonValue}'.");
			Translate<NotNullValidator>("'{PropertyName}' �� ���� ����� ���.");
			Translate<PredicateValidator>("����� ����� �� ������ ���� '{PropertyName}'.");
			Translate<AsyncPredicateValidator>("����� ����� �� ������ ���� '{PropertyName}'.");
			Translate<RegularExpressionValidator>("'{PropertyName}' ���� ������ �����.");
			Translate<EqualValidator>("'{PropertyName}' ���� ����� ���� �- '{ComparisonValue}'.");
			Translate<ExactLengthValidator>("'{PropertyName}' ���� ����� ����� {MaxLength} �����. ���� {TotalLength} �����.");
			Translate<InclusiveBetweenValidator>("'{PropertyName}' ���� ����� ��� {From} ���� {To}. ���� {Value}.");
			Translate<ExclusiveBetweenValidator>("'{PropertyName}' ���� ����� ��� {From} ���� {To} (�� ����). ���� {Value}.");
			Translate<CreditCardValidator>("'{PropertyName}' ���� ���� ����� ����� ����.");
			Translate<ScalePrecisionValidator>("'{PropertyName}' �� ���� ����� ���� �- {expectedPrecision} ����� ��� ���, �� ����� �� {expectedScale} ����� ��������. ����� {digits} ����� �- {actualScale} ����� ��������.");
			Translate<EmptyValidator>("'{PropertyName}' ���� ����� ���.");
			Translate<NullValidator>("'{PropertyName}' ���� ����� ���.");
			Translate<EnumValidator>("'{PropertyName}' ���� ���� ����� ����� ���� �� '{PropertyValue}'.");
		}
	}
}
