import { assert } from "chai";
import { removeElement } from "../src/main";

describe("main test", () => {
      it("test", () => {
      const result = removeElement([3,2,2,3], 3);
      assert.equal(result, 2);
   });
});