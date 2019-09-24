export abstract class SchemaBuilder {
  protected abstract isCreate: boolean;
  protected abstract getSchema();
  protected abstract getContext();
  protected abstract getData();
}
