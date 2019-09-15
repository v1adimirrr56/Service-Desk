import { FieldType } from './FieldType';
export class FormField {
  label: string;
  nameField: string;
  placeholder?: string;
  hidden?: boolean;
  readOnly?: boolean;
  options?: Option[];
  type?: FieldType;
  validations?: IValidation;
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
