import { assert } from "chai";
import { lengthOfLastWord } from "../src/main";

describe("main test", () => {
      it("test", () => {
      const result = lengthOfLastWord("   fly me   to   the moon  ");
      assert.equal(result, 4);
   });
});