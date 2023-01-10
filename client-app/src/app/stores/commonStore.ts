import { makeAutoObservable } from "mobx";
import { ServerError } from "../models/serverError";

export default class CommonStore {
  error: ServerError | null = null;

  constructor() {
    makeAutoObservable(this);
  }

  SetServerError(error: ServerError) {
    this.error = error;
  }
}