import { assert } from "chai";
import { removeDuplicates } from "../src/main";

describe("main test", () => {
   it("test", () => {
      let arr = [1, 1, 2];
      const result = removeDuplicates(arr);
      assert.equal(result, 2);
      assert.deepEqual(arr, [1, 2, 0]);
   });
   it("test2", () => {
      let arr = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
      const result = removeDuplicates(arr);
      assert.equal(result, 5);
      assert.deepEqual(arr, [0, 1, 2, 3, 4, 0, 0, 0, 0, 0]);
   });
   it("test3", () => {
      let arr = [1, 2];
      const result = removeDuplicates(arr);
      assert.equal(result, 2);
      assert.deepEqual(arr, [1, 2]);
   });
   it("test4", () => {
      let arr = [1, 2, 2];
      const result = removeDuplicates(arr);
      assert.equal(result, 2);
      assert.deepEqual(arr, [1, 2, 0]);
   });
});