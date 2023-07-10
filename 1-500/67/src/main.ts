
export function addBinary(a: string, b: string): string {
    let result = "";
    let carry = 0;
    let i = a.length - 1;
    let j = b.length - 1;

    while (i >= 0 || j >= 0 || carry == 1) {
        if (i >= 0)
            carry += Number(a[i--]);
        if (j >= 0)
            carry += Number(b[j--]);
        result += (carry % 2);
        carry = Math.floor(carry / 2);
    }
    return result.split('').reverse().join('');
}


