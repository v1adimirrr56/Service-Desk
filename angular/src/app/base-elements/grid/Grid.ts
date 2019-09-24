export class Grid {
  columns: IColumn[];
}
export interface IColumn {
  nameColumn: string;
  key: string;
  label: string;
}

export interface IFilter {
  propertyName: string;
  value: string;
}
