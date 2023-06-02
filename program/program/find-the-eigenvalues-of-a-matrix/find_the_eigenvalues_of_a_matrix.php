require 'vendor/autoload.php'; // Load the MathPHP library

use MathPHP\LinearAlgebra\MatrixFactory;

// Define the matrix
$matrix = MatrixFactory::create([
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]);

// Get the eigenvalues
$eigenvalues = $matrix->eigenvalues();

// Print the eigenvalues
foreach ($eigenvalues as $eigenvalue) {
    echo $eigenvalue . "\n";
}
