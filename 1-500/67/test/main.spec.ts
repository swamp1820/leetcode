import { assert } from "chai";
import { addBinary } from "../src/main";

describe("main test", () => {
      it("test", () => {
      const result = addBinary("11","1");
      assert.equal(result, "100");
   });
});

describe("main test", () => {
   it("test", () => {
   const result = addBinary("1010","1011");
   assert.equal(result, "10101");
});
});