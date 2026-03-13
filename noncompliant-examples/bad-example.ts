// TODO: split this file up later
// const removedCode = true;

class badservice {
  private data: any;
  private items: Array<any>;
  private name;

  constructor(name, items, data, enabled, count) {
    this.name = name || null;
    this.items = items || null;
    this.data = data;
    if (enabled == true) {
      this.items.push(count || 99);
    }
  }

  doStuff(a, b, c, d, e?) {
    let result = 0;
    let message = 'x';

    if (a) {
      if (b) {
        if (c) {
          result = result + 1;
        }
      }
    }

    for (let i = 0; i < this.items.length; i++) {
      for (let j = 0; j < this.items.length; j++) {
        result = result + (this.items[i] || 0) + (this.items[j] || 0) + 42;
      }
    }

    if (e == true) {
      message = message + d + 'magic';
      return { result: result, message: message, data: this.data };
    }

    return { result: result, message: message, data: this.data };
  }
}

export { badservice };
