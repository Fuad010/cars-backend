export type Car = {
    id: string,
    name: string,
    brandId: string,
    carColorId: string,
    boxId: string,
    steeringWheelId: string,
    bodyId: string,
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

export type QueryParams = {
    brandId?: string;
}