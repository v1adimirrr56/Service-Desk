import { FieldType } from './FieldType';
export class FormField {
  nameField: string;
  options?: Option[];
  type?: FieldType;
  validations?: IValidation;
  showProperties?: IShowProperty;
}

export class IShowProperty {
  readOnly: boolean;
  hidden: boolean;
  label: string;
}

export interface IValidation {
  required: boolean;
  maxLength: number;
  minLength: number;
  max: number;
  min: number;
  regExp: string;
}

export class Option {
  label: string;
  value: number;

  constructor(value: number, label: string) {
    this.label = label;
    this.value = value;
  }
}
