export type Car = {
    id: string,
    name: string,
    brandName: string,
    colorName: string,
    boxType: string,
    steeringWheelType: string,
    bodyType: string,
    engine: string,
    mileage: number,
    year: number,
    price: number,
    images: string[]
    creationDate: Date,
    editDate?: Date | null
}

export type CarObject = {
    cars: Car[]
}