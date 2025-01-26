import { SkeletonContainer } from 'shared/ui/skeleton-container'
import styles from './carListPagination.module.css'
import { carModel } from 'entities/car'
import { useEffect } from 'react'
import { observer } from 'mobx-react-lite'
import { CarCard } from 'entities/car/car-card'

export const CarListPagination = observer (() =>{
    const { store: { getCarList, carListError, carList, isLoading  } } 
    = carModel
    
    useEffect(() => {
        getCarList();
    }, [])

    if (carListError) {
        return<>{carListError}</>
    }
    return(
        <div className={styles.wrapper}>
             {isLoading ? ( 
                <SkeletonContainer defaultCount={4} />
            ) : ( 
                carList.map((car)=>(
                <CarCard
                    key={car.id}
                    id={car.id}
                    brandName={car.brandName}
                    name={car.name}
                    engine={car.engine}
                    year={car.year}
                    mileage={car.mileage}
                    price={car.price}
                    image={car.images[0]}
                />
            )))}
        </div>
    )
})