import { FormGroup } from '@angular/forms';

export const MarkAsTouched = (group: FormGroup) => {
  const keys = Object.keys(group.controls);
  keys.forEach(x => {
    if (group.controls[x].invalid)
      group.controls[x].markAsTouched();
  });
}
