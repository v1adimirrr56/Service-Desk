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
}

export class Option {
  label: string;
  value: string;

  constructor(value: string, label: string) {
    this.label = label;
    this.value = value;
  }
}
