export function removeDuplicates(nums: number[]): number {
    if (nums.length <= 1) {
        return nums.length
    }
    let n = 0;

    for (let i = 1; i < nums.length; i++) {
        if (nums[i] == nums[n]) {
            nums[i] = 0
        }
        else {
            nums[n + 1] = nums[i]
            if (n < i - 1) {
                nums[i] = 0
            }
            n = n + 1
        }
    }

    return n + 1;
};