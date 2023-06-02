let findRoots (a: float) (b: float) (c: float) =
    let discriminant = b * b - 4.0 * a * c
    if discriminant < 0.0 then
        None // No real roots exist
    else
        let sqrtDiscriminant = sqrt discriminant
        let root1 = (-b + sqrtDiscriminant) / (2.0 * a) // Calculate the first root
        let root2 = (-b - sqrtDiscriminant) / (2.0 * a) // Calculate the second root
        Some (root1, root2) // Return the roots as Some value

// Example usage
let a = 1.0
let b = -5.0
let c = 6.0

let roots = findRoots a b c

match roots with
| None -> printfn "No real roots"
| Some (root1, root2) -> printfn "Roots: %f, %f" root1 root2
