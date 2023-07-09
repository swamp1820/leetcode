export function removeElement(nums: number[], val: number): number {
    let pointer = 0;
    let count = 0;
    for (pointer = 0; pointer < nums.length; pointer++) {
        // если другое число
        if (nums[pointer] != val) {
            if (pointer != count) {
                nums[count] = nums[pointer]
            }
            
            count = count + 1;
        }
    }

    return count;
};