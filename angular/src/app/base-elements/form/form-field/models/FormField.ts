import { FieldType } from './FieldType';
export class FormField {
  label: string;
  nameField: string;
  placeholder?: string;
  hidden?: boolean;
  readOnly?: boolean;
  options?: Option[];
  type?: FieldType;
  required?: boolean;
}

export class Option {
  label: string;
  value: string;

  constructor(value: string, label: string) {
    this.label = label;
    this.value = value;
  }
}
